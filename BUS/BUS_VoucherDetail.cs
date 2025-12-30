using DAL;
using DTO;
using System;
using System.Data;

namespace BUS
{
    public class BUS_VoucherDetail
    {
        private DAL_VoucherDetail dalVoucherDetail = new DAL_VoucherDetail();

        public BUS_VoucherDetail() { }

        public DataTable GetAllVoucherDetails()
        {
            try
            {
                return dalVoucherDetail.GetAllVoucherDetails();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable GetVoucherDetailsByVoucherId(int voucherId)
        {
            try
            {
                return dalVoucherDetail.GetVoucherDetailsByVoucherId(voucherId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable GetVoucherDetailById(int detailId)
        {
            try
            {
                return dalVoucherDetail.GetVoucherDetailById(detailId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool InsertVoucherDetail(VoucherDetail voucherDetail, int performedBy, string productName, int quantity)
        {
            try
            {
                int rowAffected = dalVoucherDetail.InsertVoucherDetail(voucherDetail.voucherId, performedBy, voucherDetail.productId, productName, quantity);
                return rowAffected > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool InsertVoucherDetailSolid(VoucherDetail voucherDetail, string productName, string type, int voucherId)
        {
            try
            {
                int rowAffected = dalVoucherDetail.InsertVoucherDetailSolid(voucherId, type, voucherDetail.productId, productName, voucherDetail.quantity, voucherDetail.unitPrice);
                return rowAffected > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool UpdateVoucherDetail(VoucherDetail voucherDetail)
        {
            try
            {
                int rowAffected = dalVoucherDetail.UpdateVoucherDetail(voucherDetail.detailId, voucherDetail.voucherId, voucherDetail.productId, voucherDetail.quantity, voucherDetail.unitPrice);
                return rowAffected > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteVoucherDetail(VoucherDetail voucherDetail)
        {
            try
            {
                int rowAffected = dalVoucherDetail.DeleteVoucherDetail(voucherDetail.detailId);
                return rowAffected > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteVoucherDetailsByVoucherId(int voucherId)
        {
            try
            {
                int rowAffected = dalVoucherDetail.DeleteVoucherDetailsByVoucherId(voucherId);
                return rowAffected > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
