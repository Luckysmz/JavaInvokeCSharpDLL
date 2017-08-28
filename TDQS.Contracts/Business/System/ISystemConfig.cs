#region CLR�汾 4.0.30319.269
// SystemConfigXML ��
// ʱ�䣺6/10/2012 3:57:22 PM
// ���ƣ�ϵͳ���ø�����XML������
// ��٣�ϵͳ���ø�����XML������
//
// �����ˣ�������
// ��Ȩ��2012 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
// 2012/11/19 13:42:23, ������, ����������region��ǩ������и�ѹ�������ԣ���ʱ������
#endregion
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace TDQS.Contracts
{
    /// <summary>
    /// ϵͳ���ø�����XML������
    /// </summary>
    public interface ISystemConfig
    {
        #region ���з���

        /// <summary>
        ///  ��ȡ����
        /// </summary>
        /// <param name="node">������</param>
        /// <param name="attribute">���������ǿ�ʱ���ظ�����ֵ�����򷵻ش���ֵ</param>
        /// <returns>string</returns>
        /**************************************************
         * ʹ��ʾ��:
         * SystemConfigXML.GetCofig("Node", "")
         * SystemConfigXML.GetCofig("Node", "Attribute")
         ************************************************/
        string[] GetCofig(string name, string attribute);

        /// <summary>
        /// ��ȡ����
        /// </summary>
        /// <param name="node">��ǩ����</param>
        /// <param name="attribute">���������ǿ�ʱ���ظ�����ֵ�����򷵻ش���ֵ</param>
        /// <returns>string</returns>
        /**************************************************
         * ʹ��ʾ��:
         * SystemConfigXML.Read("Node", "")
         * SystemConfigXML.Read("Node", "Attribute")
         ************************************************/
        string Read(string node, string attribute);

        /// <summary>
        /// �ü������ƻ�ȡ��һ���ڵ�
        /// </summary>
        /// <param name="node">�ڵ�����</param>
        /// <returns>��ȡ�Ľڵ�</returns>
        XmlNode getNode(string node);

        /// <summary>
        /// �ü������ƻ�ȡ��һ���ڵ��µ�ĳ���ڵ�
        /// </summary>
        /// <param name="nodeName">���ڵ�</param>
        /// <param name="pName">�ӽڵ�</param>
        /// <returns></returns>
        string getNode(string nodeName, string pName);
        /// <summary>
        /// �ü������ƻ�ȡ��һ���ڵ�
        /// </summary>
        /// <param name="node">�ڵ�����</param>
        /// <returns>��ȡ�Ľڵ�</returns>
        XmlNode RecoverNode(string node);

        /// <summary>
        /// ��������
        /// </summary>
        /// <param name="path">·��</param>
        /// <param name="node">�ڵ�</param>
        /// <param name="element">Ԫ�������ǿ�ʱ������Ԫ�أ������ڸ�Ԫ���в�������</param>
        /// <param name="attribute">���������ǿ�ʱ�����Ԫ������ֵ���������Ԫ��ֵ</param>
        /// <param name="value">ֵ</param>
        /// <returns></returns>
        /**************************************************
         * ʹ��ʾ��:
         * SystemConfigXML.Insert("/Node", "Element", "", "Value")
         * SystemConfigXML.Insert("/Node", "Element", "Attribute", "Value")
         * SystemConfigXML.Insert("/Node", "", "Attribute", "Value")
         ************************************************/
        void Insert(string node, string element, string attribute, string value);

        /// <summary>
        ///  �����ı���ʽ���� Ĭ��Ϊѡ��
        /// </summary>
        /// <param name="node">���ڵ�</param>
        /// <param name="nodetxt">�ӽڵ�text</param>
        /// <param name="value">�ӽڵ�ֵ</param>
        void Insert(string node, string nodetxt, string value);

        /// <summary>
        /// �޸�����
        /// </summary>
        /// <param name="path">·��</param>
        /// <param name="node">�ڵ�</param>
        /// <param name="attribute">���������ǿ�ʱ�޸ĸýڵ�����ֵ�������޸Ľڵ�ֵ</param>
        /// <param name="value">ֵ</param>
        /// <returns></returns>
        /**************************************************
         * ʹ��ʾ��:
         * SystemConfigXML.Update("/Node", "", "Value")
         * SystemConfigXML.Update("/Node", "Attribute", "Value")
         ************************************************/
        void Update(string node, string attribute, string value);

        /// <summary>
        /// �޸�����
        /// </summary>
        /// <param name="path">·��</param>
        /// <param name="node">�ڵ�</param>
        /// <param name="attribute">���������ǿ�ʱ�޸ĸýڵ�����ֵ�������޸Ľڵ�ֵ</param>
        /// <param name="value">ֵ</param>
        /// <returns></returns>
        /**************************************************
         * ʹ��ʾ��:
         * SystemConfigXML.UpdateSingle("Node", "", "Value")
         * SystemConfigXML.UpdateSingle("Node", "Attribute", "Value")
         ************************************************/
        bool UpdateSingle(string node, string attribute, string value);

        /// <summary>
        /// �����������ֵ������
        /// </summary>
        /// <param name="node">���ڵ�</param>
        /// <param name="nodetxt">�ӽڵ�text</param>
        /// <param name="attribute">�ӽڵ���������</param>
        /// <param name="value">�ӽڵ�����ֵ</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        bool UpdateItem(string node, string nodetxt, string attribute, string value);

        /// <summary>
        /// �޸�����
        /// </summary>
        /// <param name="path">·��</param>
        /// <param name="path">�ڵ�text</param>
        /// <param name="node">�ڵ�</param>
        /// <param name="attribute">���������ǿ�ʱ�޸ĸýڵ�����ֵ�������޸Ľڵ�ֵ</param>
        /// <param name="value">ֵ</param>
        /// <returns></returns>
        bool UpdateSingle(string node, string nodetxt, string text, string value);

        /// <summary>
        /// ɾ������
        /// </summary>
        /// <param name="path">·��</param>
        /// <param name="node">�ڵ�</param>
        /// <param name="attribute">���������ǿ�ʱɾ���ýڵ�����ֵ������ɾ���ڵ�ֵ</param>
        /// <param name="value">ֵ</param>
        /// <returns></returns>
        /**************************************************
         * ʹ��ʾ��:
         * SystemConfigXML.Delete("/Node", "")
         * SystemConfigXML.Delete("/Node", "Attribute")
         ************************************************/
        void Delete(string node, string attribute);

        /// <summary>
        /// ɾ����
        /// </summary>
        /// <param name="node"></param>
        /// <param name="nodetxt"></param>
        void DeleteSingle(string node, string nodetxt);


        /// <summary>
        /// ��ԭĬ��ֵ
        /// </summary>
        void OverWrite();

        /// <summary>
        /// ����
        /// </summary>
        void Save();
        #endregion // ���з���

        #region ����

        /// <summary>
        /// ��ѹ�ֽ�ֵ
        /// </summary>
        double VoltageBoundary
        {
            get;
            set;
        }

        /// <summary>
        /// �Ƿ���������
        /// </summary>
        bool Orthogon { get; set; }

        #region �Զ�����

        /// <summary>
        /// �Ƿ��Զ�����
        /// </summary>
        bool AutoConn { get; set; }

        /// <summary>
        /// �Զ����߷�ʽ
        /// manualMode(���Զ���������): 0 => վ�ڽ���ͼ, 1 => �Ҽ��˵�
        /// </summary>
        int manualMode { get; set; }

        #endregion

        #region ��׽

        /// <summary>
        /// �Ƿ����ò�׽
        /// </summary>
        bool EnableCaptrue { get; set; }

        /// <summary>
        /// ��׽�뾶
        /// </summary>
        int SnapRadius { get; set; }

        #endregion

        #endregion
    }
}