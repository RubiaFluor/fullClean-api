using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace fullClean.Dominio.Models
{
    public class SalesAndProducts
    {
    public int Idproducts { get; set; }
    public int Idsales { get; set; }

    //propiedades de navegacion
    [ForeignKey("Idproducts")]
    public Products products { get; set; }

    [ForeignKey("Idsales")]
    public Sales sales { get; set; }

    }
}
