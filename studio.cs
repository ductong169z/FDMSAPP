
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
    
public partial class studio
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public studio()
    {

        this.anime_studio = new HashSet<anime_studio>();

    }


    public int StudioID { get; set; }

    public string name { get; set; }

    public System.DateTime created_at { get; set; }

    public Nullable<System.DateTime> deleted_at { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<anime_studio> anime_studio { get; set; }

}

}
