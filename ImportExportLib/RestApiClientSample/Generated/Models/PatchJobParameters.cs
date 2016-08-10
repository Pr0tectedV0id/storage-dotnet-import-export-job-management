// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace StorageImportExport.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    [JsonTransformation]
    public partial class PatchJobParameters
    {
        /// <summary>
        /// Initializes a new instance of the PatchJobParameters class.
        /// </summary>
        public PatchJobParameters() { }

        /// <summary>
        /// Initializes a new instance of the PatchJobParameters class.
        /// </summary>
        public PatchJobParameters(string friendlyName = default(string), string description = default(string), string metadata = default(string), bool? cancelRequested = default(bool?), string state = default(string), ReturnAddress returnAddress = default(ReturnAddress), ReturnShipping returnShipping = default(ReturnShipping), PackageInfomation deliveryPackage = default(PackageInfomation), bool? enableVerboseLog = default(bool?), bool? backupDriveManifest = default(bool?))
        {
            FriendlyName = friendlyName;
            Description = description;
            Metadata = metadata;
            CancelRequested = cancelRequested;
            State = state;
            ReturnAddress = returnAddress;
            ReturnShipping = returnShipping;
            DeliveryPackage = deliveryPackage;
            EnableVerboseLog = enableVerboseLog;
            BackupDriveManifest = backupDriveManifest;
        }

        /// <summary>
        /// A human-readable name for the job. May contain Unicode characters
        /// and spaces.
        /// </summary>
        [JsonProperty(PropertyName = "Properties.FriendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// A human-readable description of the job. The description may be up
        /// to 1024 characters.
        /// </summary>
        [JsonProperty(PropertyName = "Properties.Description")]
        public string Description { get; set; }

        /// <summary>
        /// Metadata associated with the job. The metadata may be up to 1024
        /// characters.
        /// </summary>
        [JsonProperty(PropertyName = "Properties.Metadata")]
        public string Metadata { get; set; }

        /// <summary>
        /// If specified, the value must be true. The service will attempt to
        /// cancel the job.
        /// </summary>
        [JsonProperty(PropertyName = "Properties.CancelRequested")]
        public bool? CancelRequested { get; set; }

        /// <summary>
        /// If specified, the value must be Shipping, which tells the
        /// Import/Export service that the package for the job has been
        /// shipped. The ReturnAddress and DeliveryPackage properties must
        /// have been set either in this request or in a previous request,
        /// otherwise the request will fail.
        /// </summary>
        [JsonProperty(PropertyName = "Properties.State")]
        public string State { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Properties.ReturnAddress")]
        public ReturnAddress ReturnAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Properties.ReturnShipping")]
        public ReturnShipping ReturnShipping { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Properties.DeliveryPackage")]
        public PackageInfomation DeliveryPackage { get; set; }

        /// <summary>
        /// Indicates whether verbose logging will be enabled.
        /// </summary>
        [JsonProperty(PropertyName = "Properties.EnableVerboseLog")]
        public bool? EnableVerboseLog { get; set; }

        /// <summary>
        /// Indicates whether the manifest files on the drives should be
        /// copied to block blobs.
        /// </summary>
        [JsonProperty(PropertyName = "Properties.BackupDriveManifest")]
        public bool? BackupDriveManifest { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.ReturnAddress != null)
            {
                this.ReturnAddress.Validate();
            }
            if (this.ReturnShipping != null)
            {
                this.ReturnShipping.Validate();
            }
            if (this.DeliveryPackage != null)
            {
                this.DeliveryPackage.Validate();
            }
        }
    }
}