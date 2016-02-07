﻿using ManagedBass.Dynamics;
using System;
using System.Collections.Generic;

namespace ManagedBass
{
    /// <summary>
    /// Managed Wrapper around BassCd
    /// </summary>
    /// <remarks>Requires basscd.dll</remarks>
    public class CDDrive : IDisposable
    {
        /// <summary>
        /// Number of CD Drives available on the System
        /// </summary>
        public static int DriveCount { get { return BassCd.DriveCount; } }

        /// <summary>
        /// The Drive Index used by Bass to identify a Drive
        /// </summary>
        public int DriveIndex { get; private set; }

        /// <summary>
        /// Gets Information about a Drive
        /// </summary>
        public CDInfo DriveInfo { get { return BassCd.GetDriveInfo(DriveIndex); } }

        CDDrive(int Index) { DriveIndex = Index; }

        public int Speed
        {
            get { return BassCd.GetSpeed(DriveIndex); }
            set { if (!BassCd.SetSpeed(DriveIndex, value)) throw new InvalidOperationException(); }
        }

        public bool HasDisk { get { return BassCd.IsReady(DriveIndex); } }

        public static IEnumerable<CDDrive> Drives
        {
            get
            {
                CDInfo info;

                for (int i = 0; BassCd.GetDriveInfo(i, out info); ++i)
                    yield return new CDDrive(i);
            }
        }

        public void Dispose() { BassCd.Release(DriveIndex); }
    }
}