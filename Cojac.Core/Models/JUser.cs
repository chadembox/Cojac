using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cojac.Core.Models
{
    public class JUser
    {
        public int Id                { get; set; }
        public string Username       { get; set; }
        public string Password       { get; set; }
        public string Name           { get; set; }
        public bool IsActive         { get; set; }
        public string Email          { get; set; }
        public string Pod            { get; set; }
        public string Address        { get; set; }
        public string City           { get; set; }
        public string State          { get; set; }
        public decimal CellPhone     { get; set; }
        public decimal HomePhone     { get; set; }
        public bool BBSBanFlag       { get; set; }
        public byte BirthdayMonth    { get; set; }
        public byte BirthdayDay      { get; set; }
        public byte AnniversaryMonth { get; set; }
        public byte AnniversaryDay   { get; set; }
        public string Spouse         { get; set; }
        public int LoyaltyUpdated    { get; set; }
        public string MLB            { get; set; }
        public string NFL            { get; set; }
        public string NCF            { get; set; }
        public string NCB            { get; set; }
        public string NBA            { get; set; }
        public string NHL            { get; set; }
        public string Website        { get; set; }
        public string Comments       { get; set; }
        public DateTime Created      { get; set; }
        public DateTime LastUpdated  { get; set; }
        public int FamilyId          { get; set; }
    }
}
