﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FinanceManager.Models.DataBase;
using FinanceManager.Models.ViewModels;
using FinanceManager.Utilities.Extensions;
using FinanceManager.Utilities.DataAnnotations;
using FinanceManager.Controllers.Session;

namespace FinanceManager.Controllers.Bills
{
    [SessionValidation]
    public class BillsController : Controller
    {
        BaseRepository<Models.DataBase.Bills> Repository = new BaseRepository<Models.DataBase.Bills>();

        public ActionResult Bills()
        {
            return View(GetBills());
        }

        public ActionResult NewBill()
        {
            return View("BillForm", new BillFormViewModel());
        }

        public ActionResult EditBill(int id)
        {
            var dbObj = Repository.GetById(id);

            var billViewModel = new BillFormViewModel
            {
                Id = dbObj.Id.ToString(),
                Description = dbObj.Description,
                Value = dbObj.Value.ToString()
            };

            return View("BillForm", billViewModel);
        }

        public ActionResult SubmitBill(BillFormViewModel billViewModel)
        {
            if (billViewModel.Id.IsNotNull())
                return UpdateBill(billViewModel);
            else
                return AddBill(billViewModel);
        }

        public ActionResult InactivateBill(int id)
        {
            var billObj = Repository.GetById(id);
            billObj.Status = "I";

            Repository.Context.SaveChanges();

            return Redirect("Bills");
        }

        private ActionResult UpdateBill(BillFormViewModel billViewModel)
        {
            var billObj = new Models.DataBase.Bills
            {
                Id = billViewModel.Id.ToInt(),
                User_Id = WebHelpers.GetSession().UserId,
                Description = billViewModel.Description,
                Value = billViewModel.Value.MoneyToDecimal(), 
                Status = "A"
            };

            Repository.Update(billObj);

            return Redirect("Bills");
        }

        private ActionResult AddBill(BillFormViewModel billViewModel)
        {
            var billObj = new Models.DataBase.Bills
            {
                User_Id = WebHelpers.GetSession().UserId,
                Description = billViewModel.Description,
                Value = billViewModel.Value.MoneyToDecimal(),
                Status = "A"
            };

            Repository.Insert(billObj);

            return Redirect("Bills");
        }

        private List<BillsViewModel> GetBills()
        {
            return Repository.Context.Bills.Where(k => k.Status == "A").ToList().Select(i => new BillsViewModel
            {
                Id = i.Id.ToString(),
                Username = Repository.Context.Users.Find(i.User_Id).Username,
                Description = i.Description,
                Value = i.Value.ToString()
            }).ToList();
        }
    }
}