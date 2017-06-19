using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public IEnumerable<CartLine> Lines { get { return lineCollection; } }

        /// <summary>
        /// Метод добавления элементов в корзину
        /// </summary>
        /// <param name="dress"></param>
        /// <param name="quantity"></param>
        public void AddItem(Dress dress, int quantity)
        {
            CartLine line = lineCollection
                .Where(b => b.Dress.DressId == dress.DressId)
                .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartLine { Dress = dress, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        /// <summary>
        /// Метод удаления элементов ищ корзины
        /// </summary>
        /// <param name="dress"></param>
        public void RemoveLine( Dress dress)
        {
            lineCollection.RemoveAll(l => l.Dress.DressId == dress.DressId);
        }

        /// <summary>
        /// Метод вычисления общей стоимости
        /// </summary>
        /// <returns></returns>
        public decimal ComputeTotalValue()
        {
            return lineCollection.Sum( e => e.Dress.Price * e.Quantity);
        }

        /// <summary>
        /// Метод очистки корзины
        /// </summary>
        public void Clear()
        {
            lineCollection.Clear();
        }

    }


    /// <summary>
    /// CartLine Педставляет товар, выбраннй пользователем, а также приобретаемое количество
    /// </summary>
    public class CartLine
    {
        public Dress Dress { get; set; }
        public int Quantity { get; set; }
    }
}
