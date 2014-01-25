using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.Text;
using zlib;
using UnityEngine;
using ICSharpCode.SharpZipLib;
using ICSharpCode.SharpZipLib.GZip;

namespace DCLib.ByteHelper
{
    public class ByteArray
    {
        private MemoryStream m_Stream = new MemoryStream();
        private BinaryReader m_reader = null;
        private BinaryWriter m_writer = null;

        public ByteArray()
        {
            Init();
        }

        public ByteArray(MemoryStream ms)
        {
            m_Stream = ms;
            Init();
        }

        public ByteArray(byte[] buffer)
        {
            m_Stream = new MemoryStream(buffer);
            Init();
        }

        private void Init()
        {
			try{
				m_writer = new BinaryWriter(m_Stream);
				m_reader = new BinaryReader(m_Stream);
			}catch(Exception e){
				Debug.Log(e.ToString());
			}
            
        }

        public int Length
        {
            get { return (int)m_Stream.Length; }
        }

        public int Postion
        {
            get { return (int)m_Stream.Position; }
            set { m_Stream.Position = value; }
        }

        public byte[] Buffer
        {
            get { return m_Stream.GetBuffer(); }
        }

        internal MemoryStream MemoryStream { get { return m_Stream; } }

        public bool readBoolean()
        {
            return m_reader.ReadBoolean();
        }

        public byte readByte()
        {
            return m_reader.ReadByte();
        }

        public void readBytes(byte[] bytes, uint offset, uint length)
        {
            byte[] tmp = m_reader.ReadBytes((int)length);
            for (int i = 0; i < tmp.Length; i++)
                bytes[i + offset] = tmp[i];
            //m_reader.ReadBytes(bytes, offset, length);
        }

        public double readDouble()
        {
            return m_reader.ReadDouble();
        }

        public float readFloat()
        {
            byte[] bytes = m_reader.ReadBytes(4);
            byte[] invertedBytes = new byte[4];
            //Grab the bytes in reverse order from the backwards index
            for (int i = 3, j = 0; i >= 0; i--, j++)
            {
                invertedBytes[j] = bytes[i];
            }
            float value = BitConverter.ToSingle(invertedBytes, 0);
            return value;

            // return m_reader.ReadFloat();
        }

        public int readInt()
        {
            return BitConverter.ToInt32(toSmallEndianArr(BitConverter.GetBytes(m_reader.ReadInt32())),0);
        }

        public short readShort()
        {
            return BitConverter.ToInt16(toSmallEndianArr(BitConverter.GetBytes(m_reader.ReadInt16())), 0);
        }

        public byte readUnsignedByte()
        {
            return m_reader.ReadByte();
        }

        public uint readUnsignedInt()
        {
            return BitConverter.ToUInt32(toSmallEndianArr(BitConverter.GetBytes(m_reader.ReadInt32())), 0);
        }

        public ushort readUnsignedShort()
        {
            return BitConverter.ToUInt16(toSmallEndianArr(BitConverter.GetBytes(m_reader.ReadUInt16())), 0);
        }

        public string readUTF()
        {
            short len = readShort();
            return readUTFBytes((uint)len);
        }

        public string readUTFBytes(uint length)
        {
            if (length == 0)
                return string.Empty;
            UTF8Encoding utf8 = new UTF8Encoding(false, true);
            byte[] encodedBytes = m_reader.ReadBytes((int)length);
            string decodedString = utf8.GetString(encodedBytes, 0, encodedBytes.Length);
            return decodedString;
        }
		
		private byte[] toSmallEndianArr(byte[] arr){
            Array.Reverse(arr);
			return arr;
		}

        public void writeBoolean(bool value)
        {
            m_writer.BaseStream.WriteByte(value ? ((byte)1) : ((byte)0));
            // m_writer.WriteBoolean(value);
        }
        public void writeByte(byte value)
        {
            m_writer.BaseStream.WriteByte(value);
            // m_writer.WriteByte(value);
        }
        public void writeBytes(byte[] buffer)
        {
            for (int i = 0; buffer != null && i < buffer.Length; i++)
                m_writer.BaseStream.WriteByte(buffer[i]);
        }
        public void writeBytes(byte[] bytes, int offset, int length)
        {
            for (int i = offset; i < offset + length; i++)
                m_writer.BaseStream.WriteByte(bytes[i]);
        }
        public void writeDouble(double value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            writeBigEndian(bytes);
        }
        public void writeFloat(float value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            writeBigEndian(bytes);
        }
        private void writeBigEndian(byte[] bytes)
        {
            if (bytes == null)
                return;
            for (int i = bytes.Length - 1; i >= 0; i--)
            {
                m_writer.BaseStream.WriteByte(bytes[i]);
            }
        }

        public void writeInt32(int value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            writeBigEndian(bytes);
        }

        public void writeInt(int value)
        {
            writeInt32(value);
        }

        public void writeShort(int value)
        {
            byte[] bytes = BitConverter.GetBytes((ushort)value);
            writeBigEndian(bytes);
        }

        public void writeUnsignedInt(uint value)
        {
            writeInt32((int)value);
        }

        public void writeUTF(string value)
        {
            UTF8Encoding utf8Encoding = new UTF8Encoding();
            int byteCount = utf8Encoding.GetByteCount(value);
            byte[] buffer = utf8Encoding.GetBytes(value);
            writeShort(byteCount);
            if (buffer.Length > 0)
                m_writer.Write(buffer);
        }

        public void writeUTFBytes(string value)
        {
            UTF8Encoding utf8Encoding = new UTF8Encoding();
            byte[] buffer = utf8Encoding.GetBytes(value);
            if (buffer.Length > 0)
                m_writer.Write(buffer);
        }

        public void Compress()
        {
            byte[] buffer = m_Stream.GetBuffer();
			ZOutputStream zs = new ZOutputStream(m_Stream);
			zs.Write(buffer, 0, buffer.Length);
			zs.Close();
            Init();
        }

        public void Uncompress()
        {
			//m_Stream.ReadByte();
			//m_Stream.ReadByte();
			//DeflateStream deflateStream = new DeflateStream(m_Stream, CompressionMode.Compress);
          // ZCompressStream
            MemoryStream ms = new MemoryStream();
            ZOutputStream zo = new ZOutputStream(ms);
            zo.Write(m_Stream.GetBuffer(), 0,(int)m_Stream.Length);
			ms.Seek(0,SeekOrigin.Begin);
			//ZInputStream zs = new ZInputStream(m_Stream);
			zo.finish();
            //zo.Close();

			m_Stream = ms;          
			resetBinary();
        }

		private void resetBinary()
		{
			m_writer.Close();
			m_reader.Close();
			Init();
		}


        public void clear()
        {
            m_Stream.Close();
            m_Stream.Dispose();
            //m_Stream.Position = 0;
            //Init();
        }
    }
}
