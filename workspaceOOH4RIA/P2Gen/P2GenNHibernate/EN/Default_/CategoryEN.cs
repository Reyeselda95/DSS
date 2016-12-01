
using System;
// Definición clase CategoryEN
namespace P2GenNHibernate.EN.Default_
{
public partial class CategoryEN
{
/**
 *	Atributo product
 */
private System.Collections.Generic.IList<P2GenNHibernate.EN.Default_.ProductEN> product;



/**
 *	Atributo categoryId
 */
private int categoryId;



/**
 *	Atributo name
 */
private string name;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo parentCategory
 */
private P2GenNHibernate.EN.Default_.CategoryEN parentCategory;



/**
 *	Atributo subCategory
 */
private System.Collections.Generic.IList<P2GenNHibernate.EN.Default_.CategoryEN> subCategory;






public virtual System.Collections.Generic.IList<P2GenNHibernate.EN.Default_.ProductEN> Product {
        get { return product; } set { product = value;  }
}



public virtual int CategoryId {
        get { return categoryId; } set { categoryId = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual P2GenNHibernate.EN.Default_.CategoryEN ParentCategory {
        get { return parentCategory; } set { parentCategory = value;  }
}



public virtual System.Collections.Generic.IList<P2GenNHibernate.EN.Default_.CategoryEN> SubCategory {
        get { return subCategory; } set { subCategory = value;  }
}





public CategoryEN()
{
        product = new System.Collections.Generic.List<P2GenNHibernate.EN.Default_.ProductEN>();
        subCategory = new System.Collections.Generic.List<P2GenNHibernate.EN.Default_.CategoryEN>();
}



public CategoryEN(int categoryId, System.Collections.Generic.IList<P2GenNHibernate.EN.Default_.ProductEN> product, string name, string descripcion, P2GenNHibernate.EN.Default_.CategoryEN parentCategory, System.Collections.Generic.IList<P2GenNHibernate.EN.Default_.CategoryEN> subCategory
                  )
{
        this.init (CategoryId, product, name, descripcion, parentCategory, subCategory);
}


public CategoryEN(CategoryEN category)
{
        this.init (CategoryId, category.Product, category.Name, category.Descripcion, category.ParentCategory, category.SubCategory);
}

private void init (int categoryId, System.Collections.Generic.IList<P2GenNHibernate.EN.Default_.ProductEN> product, string name, string descripcion, P2GenNHibernate.EN.Default_.CategoryEN parentCategory, System.Collections.Generic.IList<P2GenNHibernate.EN.Default_.CategoryEN> subCategory)
{
        this.CategoryId = categoryId;


        this.Product = product;

        this.Name = name;

        this.Descripcion = descripcion;

        this.ParentCategory = parentCategory;

        this.SubCategory = subCategory;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        CategoryEN t = obj as CategoryEN;
        if (t == null)
                return false;
        if (CategoryId.Equals (t.CategoryId))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.CategoryId.GetHashCode ();
        return hash;
}
}
}
