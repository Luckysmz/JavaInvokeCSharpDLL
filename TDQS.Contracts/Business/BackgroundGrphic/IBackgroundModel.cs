#region CLR�汾 4.0.30319.17379
// IBackgroundModel �ӿ�
// ʱ�䣺2012/4/1 11:51:50
// ���ƣ�IBackgroundModel
// ��٣�����ͼ��Ϣģ�ͽӿ�
//
// �����ˣ�������
// ��Ȩ��Copyright (C) 2012 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDQS.Contracts
{
    /// <summary>
    /// ����ͼ��Ϣģ�ͽӿ�
    /// </summary>
    public interface IBackgroundModel
    {
        #region ����
        #endregion // ����

        #region ����

        /// <summary>
        /// ָʾ��ǰ����ͼ�Ƿ�����ʱ����ͼ
        /// </summary>
        bool TempFile
        {
            get;
            set;
        }

        /// <summary>
        /// ����
        /// </summary>
        string NickName
        {
            get;
            set;
        }

        /// <summary>
        /// ���û�õ������ļ���
        /// </summary>
        string FileName
        {
            get;
            set;
        }

        /// <summary>
        /// ���û�õ�����ͼ�Ƿ�ɼ�
        /// </summary>
        bool Visible
        {
            get;
            set;
        }
        /// <summary>
        /// �ļ���
        /// </summary>
        float Width { get; set; }

        /// <summary>
        /// �ļ���
        /// </summary>
        float Heigth { get; set; }

        /// <summary>
        /// ��������X
        /// </summary>
        float X { get; set; }

        /// <summary>
        /// ��������Y
        /// </summary>
        float Y { get; set; }

        /// <summary>
        /// X�᷽�����������
        /// </summary>
        float ScaleX { get; set; }

        /// <summary>
        /// Y�᷽�����������
        /// </summary>
        float ScaleY { get; set; }

        /// <summary>
        /// ����ͼ����
        /// </summary>
        BackgroundType BackgroundType { get; set; }

        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }

    /// <summary>
    /// ����ͼ����
    /// </summary>
    public enum BackgroundType
    {
        /// <summary>
        /// shpͼ��ʽ
        /// </summary>
        Shp,
        /// <summary>
        /// JPG��ʽ
        /// </summary>
        Jpg,
        /// <summary>
        /// CAD����ͼ
        /// </summary>
        Cad
    }
}

