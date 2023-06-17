using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace AdwenturesWork.Models;

/// <summary>
/// High-level product categorization.
/// </summary>
public partial class ProductCategory
{
    /// <summary>
    /// Primary key for ProductCategory records.
    /// </summary>
    public int ProductCategoryId { get; set; }

    /// <summary>
    /// Category description.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
    /// </summary>
    public Guid Rowguid { get; set; }

    /// <summary>
    /// Date and time the record was last updated.
    /// </summary>
    public DateTime ModifiedDate { get; set; }


    public ProductCategory()
    {
    }
    public virtual ICollection<ProductSubcategory> ProductSubcategories { get; set; } = new List<ProductSubcategory>();
    public override string ToString()
    {
        return $"{ProductCategoryId}) {Name} - {ModifiedDate}";
    }
}
