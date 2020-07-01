

    
using System;
using System.ComponentModel.DataAnnotations.Schema;
//EFX Code Generation Template 1.0
//author:Tibos
//blog:www.cnblogs.com/Tibos
//Entity Code Generation Template
namespace Device
{
    [Table("device")]
	//DeviceModel;
	public class DeviceModel:BaseEntity
    {

        /// <summary>
		/// 
        /// </summary>
        public virtual string CommunityId
        {
            get; 
            set; 
        }  
        
        /// <summary>
		/// 
        /// </summary>
        public virtual string DeviceSerial
        {
            get; 
            set; 
        }  
        
        /// <summary>
		/// 
        /// </summary>
        public virtual int DeviceStatus
        {
            get; 
            set; 
        }  
        
        /// <summary>
		/// 
        /// </summary>
        public virtual string DeviceTitle
        {
            get; 
            set; 
        }  
        
        /// <summary>
		/// 
        /// </summary>
        public virtual bool IsActive
        {
            get; 
            set; 
        }  
        
        /// <summary>
		/// 
        /// </summary>
        public virtual int TenantId
        {
            get; 
            set; 
        }  
        
        /// <summary>
		/// 
        /// </summary>
        public virtual System.DateTime VipEndDate
        {
            get; 
            set; 
        }  
        
    }
}
