//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace My_First_APP
{
    using System;
    using System.Collections.Generic;
    
    public partial class Person
    {
        public Person()
        {
            this.Blank = new HashSet<Blank>();
        }
    
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Sex { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public Nullable<int> AccountId { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual ICollection<Blank> Blank { get; set; }
    }
}