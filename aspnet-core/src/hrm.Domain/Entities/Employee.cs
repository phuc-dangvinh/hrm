using hrm.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace hrm.Entities
{
    public class Employee : FullAuditedEntity<Guid>
    {
        public string Code { get; set; }
        public string FullName { get; set; }
        public Guid OutletId { get; set; }
        [ForeignKey(nameof(OutletId))]
        public Outlet Outlet { get; set; }
        public Guid PositionId { get; set; }
        [ForeignKey(nameof(PositionId))]
        public Position Position { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime Birthday { get; set; }
        public bool Gender { get; set; }
        public string? TaxCode { get; set; }
        public string PhoneNumber { get; set; }
        public string? PersonalEmail { get; set; }
        public string? CompanyEmail { get; set; }
        public MaritalStatus? MaritalStatus { get; set; }
        public WorkingStatus WorkingStatus { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public int? Height { get; set; }
        public int? Weight { get; set; }
        public bool IsLeaveJob { get; set; }
        public string? Note { get; set; }
        public Guid DepartmentId { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        public Department Department { get; set; }
        public Guid CitizenId { get; set; }
        [ForeignKey(nameof(CitizenId))]
        public Citizen Citizen { get; set; }
        public Guid EducationId { get; set; }
        [ForeignKey(nameof(EducationId))]
        public Education Education { get; set; }
        public ICollection<EnglishCertificate>? EnglishCertificates { get; set; }
        public ICollection<ITCertificate>? ITCertificates { get; set; }
        public ICollection<OtherCertificate>? OtherCertificates { get; set; }
        public Guid AddressId { get; set; }
        [ForeignKey(nameof(AddressId))]
        public Address Address { get; set; }
        public ICollection<LeaveJobDetail>? LeaveJobs { get; set; }
        public ICollection<Blacklist>? Blacklists { get; set; }
        public ICollection<RelativesContact>? RelativesContacts { get; set; }
        public ICollection<DeductionsDependent>? DeductionsDependents { get; set; }
        public ICollection<BankAccount>? BankAccounts { get; set; }
    }
}
