//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoffeHouse3914.DB
{
    using System;
    
    public partial class UDF_SupplyDate_Result
    {
        public string Название { get; set; }
        public decimal Цена { get; set; }
        public string Категория { get; set; }
        public Nullable<int> Срок_годности { get; set; }
        public System.DateTime Дата_поставки { get; set; }
        public int Количество_товара_в_поставке { get; set; }
        public string Поставщик { get; set; }
    }
}
