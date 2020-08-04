using ShopApp.Business.Abstract;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopApp.Business.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderService _orderDal;

        public OrderManager(IOrderService orderDal)
        {
            _orderDal = orderDal;
        }
        public void Create(Order entity)
        {
            _orderDal.Create(entity);
        }

        public void Delete(Order entity)
        {
            _orderDal.Delete(entity);
        }

        public List<Order> GetAll()
        {
            return _orderDal.GetAll().ToList();
        }

        public Order GetById(int id)
        {
            return _orderDal.GetById(id);
        }

        public void Update(Order entity)
        {
            _orderDal.Update(entity);
            
        }
    }
}
