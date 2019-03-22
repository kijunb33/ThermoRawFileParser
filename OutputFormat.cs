﻿namespace ThermoRawFileParser
{
    public enum OutputFormat
    {
        Mgf,
        Mzml,
        IndexMzML,
        Parquet,
        MGFNoProfileData,
        NONE
    }

    public enum MetadataFormat
    {
        JSON,
        TXT,
        PARQUET,
        NONE
    }
}