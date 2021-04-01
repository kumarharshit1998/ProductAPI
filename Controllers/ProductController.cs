using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductApi.Models;

namespace ProductApi.Controllers
{
    public class ProductController : ApiController
    {
        static List<Product> _ProductList = null;
        void Initialize()
        {
            _ProductList = new List<Product>()
           {
               new Product() {ProductId=1,Name="choclate",QtyInStock=2,Description="Dairy",Supplier="harshit"},
               new Product() {ProductId=2,Name="Lays",QtyInStock=3,Description="junk food",Supplier="harshit11"},

           };

        }
        public ProductController()
        {
            if (_ProductList == null)
            {
                Initialize();
            }
        }

        // GET: api/Product
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, _ProductList);
        }

        // GET: api/product/5
        public HttpResponseMessage Get(int id)
        {
            Product product = _ProductList.FirstOrDefault(x => x.ProductId == id);
            if (product == null)
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "product Not found");
            else
                return Request.CreateResponse(HttpStatusCode.OK, product);
        }

        // POST: api/Product
        public HttpResponseMessage Post(Product product)
        {
            if (product != null)
            {
                _ProductList.Add(product);
            }
            return Request.CreateResponse(HttpStatusCode.Created);
        }

        // PUT: api/Product/5
        public HttpResponseMessage Put(int id, Product objProduct)
        {
             Product  product = _ProductList.Where(x => x.ProductId == id).FirstOrDefault();
            if (product == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "STudent Not found");

            }
            else
            {
                if (product != null)
                {
                    foreach (Product temp in _ProductList)
                    {
                        if (temp.ProductId == id)
                        {
                            temp.Name = objProduct.Name;
                            temp.QtyInStock = objProduct.QtyInStock;
                            temp.Description = objProduct.Description;
                            temp.Supplier = objProduct.Supplier;
                        }
                    }


                }
                return Request.CreateResponse(HttpStatusCode.OK, "Modified");

            }
        }

        // DELETE: api/Product/5
        public HttpResponseMessage Delete(int id)
        {
          Product product = _ProductList.Where(x => x.ProductId == id).FirstOrDefault();
            if (product == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "product Not found");

            }
            else
            {
                if (product != null)
                {
                   _ProductList.Remove(product);
                }
                return Request.CreateResponse(HttpStatusCode.OK, "Deleteed");
            }

        }
    }
}
