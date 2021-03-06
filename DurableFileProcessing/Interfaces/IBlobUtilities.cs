﻿using Microsoft.Azure.Storage.Blob;
using System;

namespace DurableFileProcessing.Interfaces
{
    public interface IBlobUtilities
    {
        string GetSharedAccessSignature(CloudBlobContainer container, DateTimeOffset expiryTime, SharedAccessBlobPermissions accessPermissions);
        string GetSharedAccessSignature(CloudBlobContainer container, string blobName, DateTimeOffset expiryTime, SharedAccessBlobPermissions accessPermissions);
    }
}