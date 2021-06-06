﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dental_sys
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class thuctapEntities : DbContext
    {
        public thuctapEntities()
            : base("name=thuctapEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BenhNen> BenhNens { get; set; }
        public virtual DbSet<BenhNhan> BenhNhans { get; set; }
        public virtual DbSet<BuoiDieuTri> BuoiDieuTris { get; set; }
        public virtual DbSet<CaTruc> CaTrucs { get; set; }
        public virtual DbSet<Chi> Chis { get; set; }
        public virtual DbSet<ChiTietDonThuoc> ChiTietDonThuocs { get; set; }
        public virtual DbSet<CuocHen> CuocHens { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<DonThuoc> DonThuocs { get; set; }
        public virtual DbSet<HinhAnhDieuTri> HinhAnhDieuTris { get; set; }
        public virtual DbSet<Khoanchi> Khoanchis { get; set; }
        public virtual DbSet<Khoanthu> Khoanthus { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhapVatLieu> NhapVatLieux { get; set; }
        public virtual DbSet<NhomVatLieu> NhomVatLieux { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Thu> Thus { get; set; }
        public virtual DbSet<TraLuong> TraLuongs { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<VatLieu> VatLieux { get; set; }
        public virtual DbSet<XuatVatLieu> XuatVatLieux { get; set; }
        public virtual DbSet<YeuCauNhap> YeuCauNhaps { get; set; }
        public virtual DbSet<YeuCauXuat> YeuCauXuats { get; set; }
    
        public virtual ObjectResult<sp_BaoCaoTheoDichVu_Result> sp_BaoCaoTheoDichVu(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_BaoCaoTheoDichVu_Result>("sp_BaoCaoTheoDichVu", idParameter);
        }
    
        public virtual ObjectResult<sp_BDT_DichVu_Result> sp_BDT_DichVu(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_BDT_DichVu_Result>("sp_BDT_DichVu", idParameter);
        }
    
        public virtual ObjectResult<sp_BDT_HinhAnh_Result> sp_BDT_HinhAnh()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_BDT_HinhAnh_Result>("sp_BDT_HinhAnh");
        }
    
        public virtual ObjectResult<sp_BenhNen_Result> sp_BenhNen(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_BenhNen_Result>("sp_BenhNen", idParameter);
        }
    
        public virtual ObjectResult<sp_BenhNhan_BDT_Result> sp_BenhNhan_BDT()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_BenhNhan_BDT_Result>("sp_BenhNhan_BDT");
        }
    
        public virtual ObjectResult<sp_BenhNhan_not_BDT_Result> sp_BenhNhan_not_BDT()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_BenhNhan_not_BDT_Result>("sp_BenhNhan_not_BDT");
        }
    
        public virtual ObjectResult<sp_BenhNhanTiepNhan_BDT_Result> sp_BenhNhanTiepNhan_BDT(Nullable<System.DateTime> ngayTiepNhan)
        {
            var ngayTiepNhanParameter = ngayTiepNhan.HasValue ?
                new ObjectParameter("NgayTiepNhan", ngayTiepNhan) :
                new ObjectParameter("NgayTiepNhan", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_BenhNhanTiepNhan_BDT_Result>("sp_BenhNhanTiepNhan_BDT", ngayTiepNhanParameter);
        }
    
        public virtual ObjectResult<sp_BenhNhanTiepNhan_BDT_have_Result> sp_BenhNhanTiepNhan_BDT_have(Nullable<System.DateTime> ngayTiepNhan)
        {
            var ngayTiepNhanParameter = ngayTiepNhan.HasValue ?
                new ObjectParameter("NgayTiepNhan", ngayTiepNhan) :
                new ObjectParameter("NgayTiepNhan", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_BenhNhanTiepNhan_BDT_have_Result>("sp_BenhNhanTiepNhan_BDT_have", ngayTiepNhanParameter);
        }
    
        public virtual int sp_BuoiDieutriVaHinhAnh(Nullable<int> id, Nullable<System.DateTime> ngayKham, string chuanDoan, Nullable<int> chiPhi, Nullable<int> bacSi, Nullable<int> benhNhan, string ghiChu, byte[] hinh)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var ngayKhamParameter = ngayKham.HasValue ?
                new ObjectParameter("NgayKham", ngayKham) :
                new ObjectParameter("NgayKham", typeof(System.DateTime));
    
            var chuanDoanParameter = chuanDoan != null ?
                new ObjectParameter("ChuanDoan", chuanDoan) :
                new ObjectParameter("ChuanDoan", typeof(string));
    
            var chiPhiParameter = chiPhi.HasValue ?
                new ObjectParameter("ChiPhi", chiPhi) :
                new ObjectParameter("ChiPhi", typeof(int));
    
            var bacSiParameter = bacSi.HasValue ?
                new ObjectParameter("BacSi", bacSi) :
                new ObjectParameter("BacSi", typeof(int));
    
            var benhNhanParameter = benhNhan.HasValue ?
                new ObjectParameter("BenhNhan", benhNhan) :
                new ObjectParameter("BenhNhan", typeof(int));
    
            var ghiChuParameter = ghiChu != null ?
                new ObjectParameter("GhiChu", ghiChu) :
                new ObjectParameter("GhiChu", typeof(string));
    
            var hinhParameter = hinh != null ?
                new ObjectParameter("Hinh", hinh) :
                new ObjectParameter("Hinh", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_BuoiDieutriVaHinhAnh", idParameter, ngayKhamParameter, chuanDoanParameter, chiPhiParameter, bacSiParameter, benhNhanParameter, ghiChuParameter, hinhParameter);
        }
    
        public virtual ObjectResult<sp_CT_BuoiDieuTri_Result> sp_CT_BuoiDieuTri(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_CT_BuoiDieuTri_Result>("sp_CT_BuoiDieuTri", idParameter);
        }
    
        public virtual ObjectResult<sp_DonThuoc_Result> sp_DonThuoc(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_DonThuoc_Result>("sp_DonThuoc", idParameter);
        }
    
        public virtual int sp_HinhAnhBDT(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_HinhAnhBDT", idParameter);
        }
    
        public virtual ObjectResult<sp_loadDonThuoc_BDT_Result> sp_loadDonThuoc_BDT(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_loadDonThuoc_BDT_Result>("sp_loadDonThuoc_BDT", idParameter);
        }
    
        public virtual ObjectResult<sp_loadHinhAnhBDT_Result> sp_loadHinhAnhBDT(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_loadHinhAnhBDT_Result>("sp_loadHinhAnhBDT", idParameter);
        }
    
        public virtual ObjectResult<sp_NhungCaTruc_Result> sp_NhungCaTruc(Nullable<int> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_NhungCaTruc_Result>("sp_NhungCaTruc", userIdParameter);
        }
    
        public virtual ObjectResult<sp_Report_Result> sp_Report(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Report_Result>("sp_Report", idParameter);
        }
    
        public virtual int sp_TaoBDT_DichVu(Nullable<int> bDT_id, Nullable<int> dichVu_id)
        {
            var bDT_idParameter = bDT_id.HasValue ?
                new ObjectParameter("BDT_id", bDT_id) :
                new ObjectParameter("BDT_id", typeof(int));
    
            var dichVu_idParameter = dichVu_id.HasValue ?
                new ObjectParameter("DichVu_id", dichVu_id) :
                new ObjectParameter("DichVu_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_TaoBDT_DichVu", bDT_idParameter, dichVu_idParameter);
        }
    
        public virtual ObjectResult<sp_Thu_Result> sp_Thu(Nullable<System.DateTime> dayStart, Nullable<System.DateTime> dayEnd)
        {
            var dayStartParameter = dayStart.HasValue ?
                new ObjectParameter("dayStart", dayStart) :
                new ObjectParameter("dayStart", typeof(System.DateTime));
    
            var dayEndParameter = dayEnd.HasValue ?
                new ObjectParameter("dayEnd", dayEnd) :
                new ObjectParameter("dayEnd", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Thu_Result>("sp_Thu", dayStartParameter, dayEndParameter);
        }
    
        public virtual ObjectResult<sp_TimKiemTen_Result> sp_TimKiemTen(string ten)
        {
            var tenParameter = ten != null ?
                new ObjectParameter("ten", ten) :
                new ObjectParameter("ten", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_TimKiemTen_Result>("sp_TimKiemTen", tenParameter);
        }
    
        public virtual ObjectResult<sp_TongTienBDT_Result> sp_TongTienBDT(Nullable<System.DateTime> dayStart, Nullable<System.DateTime> dayEnd)
        {
            var dayStartParameter = dayStart.HasValue ?
                new ObjectParameter("dayStart", dayStart) :
                new ObjectParameter("dayStart", typeof(System.DateTime));
    
            var dayEndParameter = dayEnd.HasValue ?
                new ObjectParameter("dayEnd", dayEnd) :
                new ObjectParameter("dayEnd", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_TongTienBDT_Result>("sp_TongTienBDT", dayStartParameter, dayEndParameter);
        }
    
        public virtual ObjectResult<sp_TongTienChi_Result> sp_TongTienChi(Nullable<System.DateTime> dayStart, Nullable<System.DateTime> dayEnd)
        {
            var dayStartParameter = dayStart.HasValue ?
                new ObjectParameter("dayStart", dayStart) :
                new ObjectParameter("dayStart", typeof(System.DateTime));
    
            var dayEndParameter = dayEnd.HasValue ?
                new ObjectParameter("dayEnd", dayEnd) :
                new ObjectParameter("dayEnd", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_TongTienChi_Result>("sp_TongTienChi", dayStartParameter, dayEndParameter);
        }
    
        public virtual ObjectResult<sp_TongTienDT_Result> sp_TongTienDT(Nullable<System.DateTime> dayStart, Nullable<System.DateTime> dayEnd)
        {
            var dayStartParameter = dayStart.HasValue ?
                new ObjectParameter("dayStart", dayStart) :
                new ObjectParameter("dayStart", typeof(System.DateTime));
    
            var dayEndParameter = dayEnd.HasValue ?
                new ObjectParameter("dayEnd", dayEnd) :
                new ObjectParameter("dayEnd", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_TongTienDT_Result>("sp_TongTienDT", dayStartParameter, dayEndParameter);
        }
    
        public virtual ObjectResult<sp_TongTienNhanVien_Result> sp_TongTienNhanVien(Nullable<System.DateTime> dayStart, Nullable<System.DateTime> dayEnd)
        {
            var dayStartParameter = dayStart.HasValue ?
                new ObjectParameter("dayStart", dayStart) :
                new ObjectParameter("dayStart", typeof(System.DateTime));
    
            var dayEndParameter = dayEnd.HasValue ?
                new ObjectParameter("dayEnd", dayEnd) :
                new ObjectParameter("dayEnd", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_TongTienNhanVien_Result>("sp_TongTienNhanVien", dayStartParameter, dayEndParameter);
        }
    
        public virtual ObjectResult<sp_TongTienThu_Result> sp_TongTienThu(Nullable<System.DateTime> dayStart, Nullable<System.DateTime> dayEnd)
        {
            var dayStartParameter = dayStart.HasValue ?
                new ObjectParameter("dayStart", dayStart) :
                new ObjectParameter("dayStart", typeof(System.DateTime));
    
            var dayEndParameter = dayEnd.HasValue ?
                new ObjectParameter("dayEnd", dayEnd) :
                new ObjectParameter("dayEnd", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_TongTienThu_Result>("sp_TongTienThu", dayStartParameter, dayEndParameter);
        }
    
        public virtual ObjectResult<sp_TongTienVatLieu_Result> sp_TongTienVatLieu(Nullable<System.DateTime> dayStart, Nullable<System.DateTime> dayEnd)
        {
            var dayStartParameter = dayStart.HasValue ?
                new ObjectParameter("dayStart", dayStart) :
                new ObjectParameter("dayStart", typeof(System.DateTime));
    
            var dayEndParameter = dayEnd.HasValue ?
                new ObjectParameter("dayEnd", dayEnd) :
                new ObjectParameter("dayEnd", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_TongTienVatLieu_Result>("sp_TongTienVatLieu", dayStartParameter, dayEndParameter);
        }
    
        public virtual ObjectResult<sp_XemLuong_Result> sp_XemLuong(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_XemLuong_Result>("sp_XemLuong", idParameter);
        }
    
        public virtual int sp_XoaBDT(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_XoaBDT", idParameter);
        }
    
        public virtual int sp_XoaCTDT(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_XoaCTDT", idParameter);
        }
    
        public virtual int sp_XoaDichVu(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_XoaDichVu", idParameter);
        }
    
        public virtual int sp_XoaDonThuoc(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_XoaDonThuoc", idParameter);
        }
    
        public virtual int sp_XoaUser(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_XoaUser", idParameter);
        }
    }
}