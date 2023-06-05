using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MyVillage.Model
{
    internal class HouseProperties : House
    {
        public bool IsForRent { get; set; }
        public bool IsForSale { get; set; }
        public bool? IsRented { get; set; }
        public decimal? RentPrice { get; set; }
        public decimal? SalePrice { get; set; }

        public HouseProperties()
        {

        }
        public HouseProperties(int bathroom, int bedroom, int livingRoom, bool hasYard, bool isForRent, bool isForSale) : base(bathroom, bedroom, livingRoom, hasYard)
        {
            IsForRent = isForRent;
            IsForSale = isForSale;
        }

        public override string ToString()
        {
            if (IsForRent || IsForSale)
            {
                return base.ToString() + $"Está para aluguel: {boolResponse(IsForRent)}\n" +
                                         $"Está para venda: {boolResponse(IsForSale)}";
            }
            return base.ToString();


        }
        
    }
}
