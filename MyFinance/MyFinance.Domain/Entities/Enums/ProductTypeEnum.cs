using System.ComponentModel;

namespace MyFinance.Domain.Entities.Enums
{
    public enum ProductTypeEnum
    {
        [Description("Vestuário")]
        clothing,
        [Description("Alimento não perecível")]
        nonPerishableFood,
        [Description("Alimento perecível")]
        perishableFood,
        [Description("Plástico")]
        plastic,
        [Description("Corrosível")]
        corrosive,
        [Description("Metal")]
        metal,
        [Description("Aço")]
        steel,
        [Description("Móveis")]
        forniture,
        [Description("Madeira")]
        wood,
        [Description("Eletrônicos")]
        eletronics,
        [Description("Eletrodoméstico")]
        appliances


,

    }
}
