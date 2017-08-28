#region CLR�汾 4.0.30319.239
// Enumerations ��
// ʱ�䣺2011-12-8 9:33:24
// ���ƣ�
// ��٣�
//
// �����ˣ�����
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
// 2013/4/3 13:18:54, ������, DrawObjectType��Ϊλ��ģʽ������һ��DrawObject��Ӧ����ͼԪ�����
#endregion
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDQS.Contracts
{
    /// <summary>
    /// ���ƶ�������
    /// </summary>
    [Flags]
    public enum DrawObjectType
    {
        /// <summary>
        /// �ڵ�
        /// </summary>
        Node,
        /// <summary>
        /// ֱ��
        /// </summary>
        Line,
        /// <summary>
        /// ����
        /// </summary>
        PolyLine,
        /// <summary>
        /// ��
        /// </summary>
        Polygon
    }

    /// <summary>
    /// ������ͼ��ʾ����
    /// </summary>
    public enum CanvasViewOpenType
    {
        /// <summary>
        /// ����ͼ
        /// </summary>
        Main,
        /// <summary>
        /// �豸��ͼ
        /// </summary>
        DeviceView,
        /// <summary>
        /// ������ͼ
        /// </summary>
        SubNetwork
    }

    /// <summary>
    /// ������ͼ�ر�ģʽ
    /// </summary>
    public enum ViewCloseMode
    {
        /// <summary>
        /// ����
        /// </summary>
        Hide,
        /// <summary>
        /// �ر�
        /// </summary>
        Close
    }
}