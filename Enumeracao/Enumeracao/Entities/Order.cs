using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text;
using Enumeracao.Entities.Enums;
using Microsoft.VisualBasic;

namespace Enumeracao.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void addItem(OrderItem item)
        {
            this.Items.Add(item);
        }

        public void removeItem(OrderItem item)
        {
            this.Items.Remove(item);
        }

        public Double total()
        {
            Double soma = 0;
            for(int i = 0; i < Items.Count; i++)
            {
                soma += Items[i].subTotal();
            }

            return soma;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Order moment: {this.Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine($"Order status: {this.Status}");
            sb.AppendLine($"Client: {this.Client.ToString()}");
            sb.AppendLine("Order items: ");
            foreach(OrderItem item in Items )
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine($"Total price: ${total().ToString("F2",CultureInfo.InvariantCulture)}");

            return sb.ToString();
        }

    }
}
