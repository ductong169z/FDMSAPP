
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
    
public partial class anime
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public anime()
    {

        this.anime_studio = new HashSet<anime_studio>();

    }


    public int AnimeID { get; set; }

    public int AccountID { get; set; }

    public Nullable<int> SeasonID { get; set; }

    public string type { get; set; }

    public string name { get; set; }

    public Nullable<System.DateTime> releaseDate { get; set; }

    public string rating { get; set; }

    public string episodes { get; set; }

    public string status { get; set; }

    public string duration { get; set; }

    public string description { get; set; }

    public string poster { get; set; }

    public string trailer { get; set; }

    public System.DateTime created_at { get; set; }

    public Nullable<System.DateTime> deleted_at { get; set; }



    public virtual account account { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<anime_studio> anime_studio { get; set; }

}

}