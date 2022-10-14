﻿// <copyright file="MyXmlSerializer.cs" company="IlyaRebikau">
// Copyright (c) IlyaRebikau. All rights reserved.
// </copyright>

namespace CourseWork.DAL.Services
{
    using System.Xml.Serialization;
    using CourseWork.DAL.Interfaces;

    /// <summary>
    /// Helper for work with XML serialization and deserialization.
    /// </summary>
    /// <typeparam name="T">Object for serialization and deserialization.</typeparam>
    public class MyXmlSerializer<T> : ISerializer<T>
    {
        /// <inheritdoc/>
        public T ReadObject(string data)
        {
            using TextReader reader = new StringReader(data);
            var xmlSerializer = new XmlSerializer(typeof(T));
            var myObject = (T)xmlSerializer.Deserialize(reader);
            return myObject;
        }

        /// <inheritdoc/>
        public void WriteObject(T myObject, string path)
        {
            using StreamWriter writer = new StreamWriter(path);
            var xmlSerializer = new XmlSerializer(typeof(T));
            xmlSerializer.Serialize(writer, myObject);
            writer.Close();
        }
    }
}