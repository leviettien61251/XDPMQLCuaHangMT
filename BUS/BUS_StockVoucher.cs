using DAL;
using DTO;
using System;
using System.Data;

namespace BUS
{
    public class BUS_StockVoucher
    {
        private DAL_StockVoucher dalStockVoucher = new DAL_StockVoucher();

        public BUS_StockVoucher() { }

        public DataTable GetAllStockVouchers()
        {
            try
            {
                return dalStockVoucher.GetAllStockVouchers();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable GetStockVoucherById(int voucherId)
        {
            try
            {
                return dalStockVoucher.GetStockVoucherById(voucherId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool InsertStockVoucher(StockVoucher stockVoucher)
        {
            try
            {
                int rowAffected = dalStockVoucher.InsertStockVoucher(stockVoucher.voucherType, stockVoucher.createdBy, stockVoucher.note);
                return rowAffected > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public object InsertStockVoucherSolid(StockVoucher stockVoucher)
        {
            try
            {
                return dalStockVoucher.InsertStockVoucherSolid(stockVoucher.voucherType, stockVoucher.createdBy, stockVoucher.note);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool UpdateStockVoucher(StockVoucher stockVoucher)
        {
            try
            {
                int rowAffected = dalStockVoucher.UpdateStockVoucher(stockVoucher.voucherId, stockVoucher.voucherType, stockVoucher.note);
                return rowAffected > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteStockVoucher(StockVoucher stockVoucher)
        {
            try
            {
                int rowAffected = dalStockVoucher.DeleteStockVoucher(stockVoucher.voucherId);
                return rowAffected > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
