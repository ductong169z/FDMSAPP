
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

    public int AnimeID { get; set; }

    public int AccountID { get; set; }

    public Nullable<int> SeasonID { get; set; }

    public string type { get; set; }

    public string name { get; set; }

    public string releaseDate { get; set; }

    public string rating { get; set; }

    public Nullable<int> episodes { get; set; }

    public string status { get; set; }

    public string duration { get; set; }

    public string description { get; set; }

    public string poster { get; set; }

    public string trailer { get; set; }

    public System.DateTime created_at { get; set; }

    public Nullable<System.DateTime> deleted_at { get; set; }



    public virtual account account { get; set; }

}

}
