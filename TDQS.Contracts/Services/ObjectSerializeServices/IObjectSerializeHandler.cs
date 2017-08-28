#region CLR�汾 4.0.30319.239
// IDataExchangeHandler �ӿ�
// ʱ�䣺2011-11-10 14:04:17
// ���ƣ�IDataExchangeHandler �ӿ�
// ��٣��������л����� �������ӿ�
//
// �����ˣ�����ΰ
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
// 2012.9.6 ����        ����֧�����ݿ��������ʽ��Ҫ����
#endregion
using System;
using System.IO;
using System.Collections.Generic;

namespace TDQS.Contracts
{
    /// <summary>
    /// �������л����� �������ӿ�
    /// </summary>
    public interface ISerializeHandler
    {
        #region ����
        /// <summary>
        /// �����ļ������л��ɶ���
        /// </summary>
        /// <param name="filePath">�ļ�·��</param>
        /// <param name="type">��������</param>
        /// <returns>����</returns>
        object Load(string filePath, System.Type type);
        /// <summary>
        /// �����ļ������л��ɶ���
        /// </summary>
        /// <param name="filePath">�ļ�·��</param>
        /// <param name="type">��������</param>
        /// <param name="types">����������������</param>
        /// <returns>����</returns>
        object Load(string filePath, System.Type type, System.Type[] types);
        /// <summary>
        /// ���������л����ļ���
        /// </summary>
        /// <param name="filePath">·��</param>
        /// <param name="obj">����</param>
        /// <param name="type">��������</param>
        void Save(string filePath, object obj, System.Type type);
        /// <summary>
        /// ���������л����ļ���
        /// </summary>
        /// <param name="filePath">·��</param>
        /// <param name="obj">����</param>
        /// <param name="type">��������</param>
        /// <param name="types">������������</param>
        void Save(string filePath, object obj, System.Type type, System.Type[] types);

        /// <summary>
        /// �����������л��ɶ���
        /// </summary>
        /// <param name="textReader">�ı���ȡ��</param>
        /// <param name="type">��������</param>
        /// <returns>����</returns>
        object Load(TextReader textReader, System.Type type);
        /// <summary>
        /// �����������л��ɶ���
        /// </summary>
        /// <param name="textReader">�ı���ȡ��</param>
        /// <param name="type">��������</param>
        /// <param name="types">������������</param>
        /// <returns>����</returns>
        object Load(TextReader textReader, System.Type type, System.Type[] types);
        /// <summary>
        /// ���������л�������
        /// </summary>
        /// <param name="textWriter">�ı��༭��</param>
        /// <param name="obj">����</param>
        /// <param name="type">��������</param>
        void Save(TextWriter textWriter, object obj, System.Type type);
        /// <summary>
        /// ���������л�������
        /// </summary>
        /// <param name="textWriter">�ı��༭��</param>
        /// <param name="obj">����</param>
        /// <param name="type">��������</param>
        /// <param name="types">������������</param>
        void Save(TextWriter textWriter, object obj, System.Type type, System.Type[] types);


        /// <summary>
        /// �����������л��ɶ���
        /// </summary>
        /// <param name="stream">��</param>
        /// <param name="type">��������</param>
        /// <returns>����</returns>
        object Load(Stream stream, System.Type type);
        /// <summary>
        /// �����������л��ɶ���
        /// </summary>
        /// <param name="stream">��</param>
        /// <param name="type">��������</param>
        /// <param name="types">������������</param>
        /// <returns>����</returns>
        object Load(Stream stream, System.Type type, System.Type[] types);
        /// <summary>
        /// ���������л�������
        /// </summary>
        /// <param name="stream">��</param>
        /// <param name="obj">����</param>
        /// <param name="type">��������</param>
        void Save(Stream stream, object obj, System.Type type);
        /// <summary>
        /// ���������л�������
        /// </summary>
        /// <param name="stream">��</param>
        /// <param name="obj">����</param>
        /// <param name="type">��������</param>
        /// <param name="types">������������</param>
        void Save(Stream stream, object obj, System.Type type, System.Type[] types);

        #endregion // ����

        #region ����
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

