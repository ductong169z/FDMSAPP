
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace FMSAPP
{

using System;
    using System.Collections.Generic;
    
public partial class account
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public account()
    {

        this.animes = new HashSet<anime>();

    }


    public int AccountID { get; set; }

    public int RoleID { get; set; }

    public string username { get; set; }

    public string password { get; set; }

    public string fullname { get; set; }

    public string avatar { get; set; }

    public string email { get; set; }

    public Nullable<int> gender { get; set; }

    public System.DateTime created_at { get; set; }

    public Nullable<System.DateTime> deleted_at { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<anime> animes { get; set; }

    public virtual role role { get; set; }

}

}
