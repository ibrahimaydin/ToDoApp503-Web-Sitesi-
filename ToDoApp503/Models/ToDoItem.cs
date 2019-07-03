﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ToDoApp503.Models
{
    public class ToDoItem : BaseEntity
    {
        [StringLength(200)]
        [Required(ErrorMessage ="Bu Alan zorunludur")]
        [DisplayName("Başlık")]
        public string Title { get; set; }

        [DisplayName("Açıklama")]
        public string Description { get; set; }

        [DisplayName("Durum")]
        public Status Status { get; set; }

        [DisplayName("Kategori")]
        public int? CategoryId { get; set; }
       [ForeignKey("CategoryId")]
        [DisplayName("Kategori")]
        public virtual Category Category { get; set; }

        [StringLength(200)]
        [DisplayName("Dosya Eki")]
        public string Attachment { get; set; }

         [DisplayName("Departman")]
        public int? DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        [DisplayName("Departman")]
        public virtual Department Department { get; set; }

        [DisplayName("Taraf")]
        public int? SideId { get; set; }
        [ForeignKey("SideId")]
       [DisplayName("Taraf")]
       public virtual Side Side { get; set; }


        [DisplayName("Müşteri")]
        public int? CustomerId { get; set; }
        [ForeignKey("CustomerId")]
         [DisplayName("Müşteri")]
        public virtual Customer Customer { get; set; }


        [DisplayName("Yönetici")]
        public int? ManagerId { get; set; }
        [ForeignKey("ManagerId")]
        [DisplayName("Yönetici")]
        public virtual Contact Manager { get; set; }


        [DisplayName("Organizatör")]
        public int? OrganizatorId { get; set; }
        [ForeignKey("OrganizatorId")]
         [DisplayName("Organizatör")]
        public virtual Contact Organizator { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        [DisplayName("Toplantı Tarihi")]
        [Required(ErrorMessage ="Bu ALAN zorunludur.")]
        public DateTime MeetingDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("Planlanan Tarih")]
        [Required(ErrorMessage = "Bu ALAN zorunludur.")]
        public DateTime PlannedDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("Bitirme Tarihi")]
        [Required(ErrorMessage = "Bu ALAN zorunludur.")]
        public DateTime FinishDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("Revize Tarihi")]
        [Required(ErrorMessage = "Bu ALAN zorunludur.")]
        public DateTime ReviseDate { get; set; }
        [DisplayName("Görüşme konusu")]
        public string ConversationSubject { get; set; }
        [DisplayName("Destekleyen Firma")]
        public string SupporterCompany { get; set; }
        [DisplayName("Destekleyen Doktor")]
        public string SupporterDoctor { get; set; }
        [DisplayName("Görüşme katılım sayısı")]
        public int ConversationAttendeeCount { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("Planlanan Organizasyon Tarihi")]
        [Required(ErrorMessage ="Bu ALAN zorunludur.")]
        public DateTime ScheduledOrganizationDate { get; set; }
        [DisplayName("Mailing Konusuı")]
        public string MailingSubject { get; set; }
        [DisplayName("Afiş Konusu")]
        public string PosterSubject { get; set; }
        [DisplayName("Afiş Sayısı")]
        public int PosterCount { get; set; }
        [DisplayName("Uzaktan Eğitim")]
        public string Elearning { get; set; }
        [DisplayName("Tarama Türleri")]
        public string TypeOfScans { get; set; }
        [DisplayName("Taramalardaki ASO Sayısı")]
        public string AsoCountInScans { get; set; }
        [DisplayName("Organizasyon Türleri")]
        public string TypesOfOrganization { get; set; }
        [DisplayName("Organizasyondaki ASO Sayısı")]
        public string AsoCountInOrganization { get; set; }
        [DisplayName("Aşı Organizasyon Türleri")]
        public string TypesOfVaccinationOrganization { get; set; }
        [DisplayName("Aşı Organizasyonundaki ASO Sayısı")]
        public string AsoCountInVaccinationOrganization { get; set; }
        [DisplayName("Afiş için Tazminat Miktarı")]
        public string AmountOfCompensationForPoster { get; set; }
        [DisplayName("Kurumsal Verimlilik Raporu")]
        public string CorporateProductivityReport { get; set; }

    }
}