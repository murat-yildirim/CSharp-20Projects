using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_EntityFrameworkStatictics
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		Db3Project20Entities db = new Db3Project20Entities();
		private void Form1_Load(object sender, EventArgs e)
		{
			//TOPLAM KATEGORİ SAYISI
			int categoryCount = db.TblCategory.Count();
			lblCategoryCount.Text = categoryCount.ToString();

			//toplam ürün sayısı
			int productCount = db.TblProduct.Count();
			lblProductCount.Text = productCount.ToString();

			//TOPLAM MÜŞTERİ SAYISI
			int customerCount = db.TblCustomer.Count();
			lblCustomerCount.Text = customerCount.ToString();

			//TOPLAM SİPARİŞ SAYISI
			int orderCount = db.TblOrder.Count();
			lblOrderCount.Text = orderCount.ToString();

			//TOPLAM STOK SAYISI
			var totalProductStockCount = db.TblProduct.Sum(x => x.ProductStock);
			lblProductTotalStock.Text = totalProductStockCount.ToString();

			//ORTALAMA ÜRÜN FİYATI
			var averageProductPrice = db.TblProduct.Average(x => x.ProductPrice);
			lblProductAveragePrice.Text = averageProductPrice.ToString() + " TL";

			//TOPLAM MEYVE STOĞU SAYISI
			var totalProductCountByCategoryIsFurit = db.TblProduct.Where(x => x.CategoryId == 1).Sum(y => y.ProductStock);
			lblProductCountByCategoryIsFruit.Text = totalProductCountByCategoryIsFurit.ToString();

			//GAZOZ İSİMLİ ÜRÜNÜN TOPLAM İŞLEM HACMİ
			var totalPriceByProductNameIsGazozGetStock = db.TblProduct.Where(x => x.ProductName == "Gazoz").Select(y => y.ProductStock).FirstOrDefault();
			var totalPriceByProdcutNameIsGazozGetUnitPrice = db.TblProduct.Where(x => x.ProductName == "Gazoz").Select(y => y.ProductPrice).FirstOrDefault();
			var totalPriceByProductNameIsGazoz = totalPriceByProductNameIsGazozGetStock * totalPriceByProdcutNameIsGazozGetUnitPrice;
			lblTotalPriceByProductNameIsGazoz.Text = totalPriceByProductNameIsGazoz.ToString() + " TL";

			//STOK SAYISI 100'DEN AZ OLAN ÜRÜN SAYISI
			var productCountByStockCountSmallerThen100 = db.TblProduct.Where(x => x.ProductStock < 100).Count();
			lblProductStockSmallerThen100.Text = productCountByStockCountSmallerThen100.ToString();

			//KATEGORİSİ SEBZE VE DURUMU AKTİF (TRUE) OLAN ÜRÜN STOK TOPLAMI
			//int id = db.TblCategory.Where(x => x.CategoryName == "Sebze").Select(y => y.CategoryId).FirstOrDefault();
			var productStockCountByCategoryNameIsSebzeAndStatusIsTrue = db.TblProduct.Where(x => x.CategoryId == (db.TblCategory.Where(w => w.CategoryName == "Sebze").Select(y => y.CategoryId).FirstOrDefault()) && x.ProductStatus == true).Sum(y => y.ProductStock);
			lblProductCountByCategorySebzeAndStatusTrue.Text = productStockCountByCategoryNameIsSebzeAndStatusIsTrue.ToString();

			//TÜRKİYE'DEN YAPILAN SİPARİŞLER SQL QUERY
			var orderCountFromTurkiye = db.Database.SqlQuery<int>("Select count(*) From TblOrder Where CustomerId In(Select CustomerId From TblCustomer Where CustomerCountry='Türkiye')").FirstOrDefault();
			lblOrderCountFromTurkiyeBySQL.Text = orderCountFromTurkiye.ToString();

			//TÜRKİYE'DEN YAPILAN SİPARİŞLER EF METODU

			var turkishCustomerIds = db.TblCustomer.Where(x => x.CustomerCountry == "Türkiye")
													.Select(y => y.CustomerId)
													.ToList();
			var orderCountFromTurkiyeWithEf = db.TblOrder.Count(z => turkishCustomerIds.Contains(z.CustomerId.Value));
			lblOrderCountFromTurkiyeByEf.Text = orderCountFromTurkiyeWithEf.ToString();

			// SİPARİŞLER İÇİNDE KATEGORİSİ MEYVE OLAN ÜRÜNLERİN TOPLAM SATIŞ FİYATI SQL QUERY

			var orderTotalPriceByCategoryIsMeyve = db.Database.SqlQuery<decimal>("Select sum(o.totalPrice) as TotalPrice From TblOrder o JOIN TblProduct p On o.ProductId=p.ProductId JOIN TblCategory c On p.CategoryId =c.CategoryId Where c.CategoryName='Meyve'").FirstOrDefault();
			lblOrderTotalPriceByCategoryIsMeyve.Text = orderTotalPriceByCategoryIsMeyve.ToString() + " TL";

			// SİPARİŞLER İÇİNDE KATEGORİSİ MEYVE OLAN ÜRÜNLERİN TOPLAM SATIŞ FİYATI EF METODU
			var orderTotalPriceByCategoryIsMeyveWithEf = (from o in db.TblOrder
														  join p in db.TblProduct on o.ProductId equals p.ProductId
														  join c in db.TblCategory on p.CategoryId equals c.CategoryId
														  where c.CategoryName == "Meyve"
														  select o.TotalPrice).Sum();
			lblOrderTotalPriceByCategoryIsMeyveByEf.Text = orderTotalPriceByCategoryIsMeyveWithEf.ToString() + " TL";

			// SON EKLENEN ÜRÜNÜN ADI

			var lastProductName = db.TblProduct.OrderByDescending(x => x.ProductId).Select(y => y.ProductName).FirstOrDefault();
			lblLastProductName.Text = lastProductName.ToString();

			// SON EKLENEN ÜRÜNÜN KATEGERİ ADI

			var lastProductCategoryId = db.TblProduct.OrderByDescending(x => x.ProductId).Select(y => y.CategoryId).FirstOrDefault();
			var lastProductCategoryName = db.TblCategory.Where(x => x.CategoryId == lastProductCategoryId).Select(y => y.CategoryName).FirstOrDefault();
			lblLastProductCategoryName.Text = lastProductCategoryName.ToString();

			// AKTİF ÜRÜN SAYISI

			var activeProductCount = db.TblProduct.Where(x => x.ProductStatus == true).Count();
			lblActiveProductCount.Text = activeProductCount.ToString();

			// TOPLAM KOLA STOK SATIŞLARINDAN KAZANILAN PARA
			var colaStock = db.TblProduct.Where(x => x.ProductName == "Kola").Select(y => y.ProductStock).FirstOrDefault();
			var colaPrice = db.TblProduct.Where(x => x.ProductName == "Kola").Select(y => y.ProductPrice).FirstOrDefault();
			var totalColaStockPrice = colaStock * colaPrice;
			lblTotalPriceWithStockByCola.Text = totalColaStockPrice.ToString() + " TL";

			// SON SİPARİŞİ VEREN MÜŞTERİNİN ADI SOYADI

			var lastCustomerId = db.TblOrder.OrderByDescending(x => x.OrderId).Select(y => y.CustomerId).FirstOrDefault();
			var lastCustomerName = db.TblCustomer.Where(x => x.CustomerId == lastCustomerId).Select(y => y.CustomerName).FirstOrDefault();
			lblLastCustomerName.Text = lastCustomerName.ToString();

			
			// ÜLKE ÇEŞİTLİLİĞİ SAYISI

			var countryDifferentCount = db.TblCustomer.Select(x=>x.CustomerCountry).Distinct().Count();
			lblCountryDifferentCount.Text= countryDifferentCount.ToString();
		}
	}
}
