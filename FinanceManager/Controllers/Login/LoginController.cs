using Microsoft.AspNetCore.Mvc;
using FinanceManager.Models.DataBase;
using System.Linq;
using FinanceManager.Models;
using FinanceManager.Utilities.Extensions;
using FinanceManager.Models.ViewModels;
using FinanceManager.Controllers.Session;
using System;
using FinanceManager.Models.Exceptions;
using System.Threading.Tasks;

namespace FinanceManager.Controllers.Login
{
    public class LoginController : Controller
    {
        public DatabaseContext Context = new DatabaseContext();

        public ActionResult Login()
        {
            ViewBag.IsFirstAccess = false;

            return View();
        }

        public ActionResult RegisterUser()
        {
            return View();
        }

        public ActionResult SubmitLogin(LoginViewModel loginObj)
        {
            try
            {
                var db = new DatabaseController();

                if (db.DbNotExists())
                    db.CreateDatabase();

                if (db.DbIsNotRequiredVersion())
                    db.UpdateDatabase();

                if (Context.Users.ToList().Count() == 0)
                    throw new FirstAccessException("No users in DataBase, please register.");

                var userObj = Context.Users.Where(i => i.Username == loginObj.Username).FirstOrDefault();

                if (LoginIsOk(loginObj, userObj))
                {
                    if (LastYearIsNotThisYear(userObj.Id))
                        InsertMonths(userObj);

                    WebHelpers.SetSession(userObj);

                    return Redirect("/Home/Home");
                }
                else
                    throw new Exception("Wrong password");
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;

                ViewBag.IsFirstAccess = ex is FirstAccessException;

                return View("Login");
            }
        }

        private bool LoginIsOk(LoginViewModel loginObj, Users userObj)
        {
            if (userObj.IsNull())
                throw new Exception("User not found.");

            return loginObj.Password.Trim().ToSha256() == userObj.Password;
        }

        public ActionResult SaveUser(RegisterViewModel registerObj)
        {
            try
            {
                Context.Users.Add(new Users
                {
                    Username = registerObj.Username,
                    Password = registerObj.Password.Trim().ToSha256(),
                    Salary = registerObj.Salary.MoneyToDecimal(),
                    MaxExpenses = registerObj.MaxExpenses.MoneyToDecimal()
                });

                Context.SaveChanges();

                ViewBag.IsFirstAccess = false;

                return View("Login");
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;

                return View("Regiser");
            }
        }

        public bool LastYearIsNotThisYear(int userId)
        {
            var lastMonth = Context.Months.Where(i => i.User_Id == userId).ToList();

            if (lastMonth.Count == 0)
                return true;
            else
                return lastMonth.OrderByDescending(i => i.Month)
                    .Take(1).FirstOrDefault()
                    .Month.Year < DateTime.Now.Year;
        }

        public void InsertMonths(Users userObj)
        {
            for (int i = 1; i <= 12; i++)
            {
                Context.Months.Add(new Models.DataBase.Months
                {
                    User_Id = userObj.Id,
                    Month = Convert.ToDateTime($"{DateTime.Now.Year}-{i}-01"),
                    TotalIncome = 0,
                    TotalExpense = 0,
                    TotalProfit = 0,
                    Salary = userObj.Salary,
                    SalaryIsManualInput = false
                });
            }

            Context.SaveChanges();
        }

        public ActionResult LogOut()
        {
            WebHelpers.DestorySession();

            return Redirect("/Login/Login");
        }
    }
}