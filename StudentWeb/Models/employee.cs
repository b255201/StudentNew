
//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------


namespace StudentWeb.Models
{

using System;
    using System.Collections.Generic;
    
public partial class employee
{

    public int employeeId { get; set; }

    public string employeeName { get; set; }

    public string employeeAccount { get; set; }

    public byte[] employeePwd { get; set; }

    public byte[] employeeSalt { get; set; }

    public int employeeCategoryId { get; set; }

    public Nullable<System.DateTime> employeeOnBoardDate { get; set; }

    public Nullable<System.DateTime> employeeLeaveDate { get; set; }

    public string employeePhoto { get; set; }

    public Nullable<System.DateTime> createTime { get; set; }

    public Nullable<System.DateTime> modifyTime { get; set; }



    public virtual employeeCategory employeeCategory { get; set; }

}

}
