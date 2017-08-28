#region CLR�汾 4.0.30319.269
// INoteBuilder �ӿ�
// ʱ�䣺2012-09-25 9:03:37
// ���ƣ���ע�����ӿ�
// ��٣������ע�����߼��͸����߼�
//
// �����ˣ�����
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
    /// ��ע�����ӿ�
    /// </summary>
    public interface INoteBuilder
    {
        #region ����
        ///// <summary>
        ///// ˢ������Ԫ����ע
        ///// </summary>
        ///// <param name="doc">�ĵ�</param>
        //void RefreshAllElementNotes(IDocument doc);

        ///// <summary>
        // /// ˢ������ʽ
        // /// </summary>
        // /// <param name="noteGroup"></param>
        // void SetGroupStyle(NoteGroup grp);
        /// <summary>
        /// ˢ��Ԫ����ע����
        /// </summary>
        /// <param name="elem"></param>
        /// <param name="propName"></param>
        void UpdateElementNote(IElement elem, string propName);

        /// <summary>
        /// ������·��ע
        /// </summary>
        void BuildShortNotes();

        /// <summary>
        /// ����Ԫ����ע
        /// </summary>
        /// <param name="elem"></param>
        /// <returns></returns>
        IDrawObject BuildElementNote(IElement elem);

        /// <summary>
        /// ����������ע
        /// </summary>
        void BuildFlowNotes();

        /// <summary>
        /// �õ�Ԫ����ע�ı�
        /// </summary>
        /// <param name="elem">Ԫ��</param>
        /// <returns>��ע�ı�</returns>
        string GetElementNoteText(IElement elem);

        /// <summary>
        /// �����ע����
        /// </summary>
        void SaveConfig();
        /// <summary>
        /// ��鲻����ͼԪ��Ԫ����Ч�鷽ʽ��Ҫ�Ľ���
        /// </summary>
        void CheckElementToShape();

        /// <summary>
        /// ���츽�ӱ�ע�����ϵ㣬������ȣ�
        /// </summary>
        /// <param name="additionalInfo">���ӱ�ע��Ϣ</param>
        /// <returns>�Ƿ�ɹ�</returns>
        bool BuildAdditionalNote(object additionalInfo);

        /// <summary>
        /// ���¸��ӱ�ע�����ϵ㣬������ȣ�
        /// </summary>
        /// <param name="additionalInfo">���ӱ�ע��Ϣ</param>
        void UpdateAdditionalNote(object additionalInfo);

        /// <summary>
        /// ɾ�����ӱ�ע�����ϵ㣬������ȣ�
        /// </summary>
        /// <param name="additionalInfo">���ӱ�ע��Ϣ</param>
        void DeleteAdditionalNote(object additionalInfo);

        /// <summary>
        /// ɾ�����и��ӱ�ע
        /// </summary>
        /// <param name="additionalInfos">���ӱ�ע��Ϣ</param>
        void DeleteAllAdditionalNote(object additionalInfos);

        /// <summary>
        /// �����ɿ��Ա�ע
        /// </summary>
        void BuildReliabilityNotes();

        #endregion // ����

        #region ����
        /// <summary>
        /// ��ȡ�����ñ�ע��ʾ״̬
        /// </summary>
        bool IsNoteVisible
        {
            get;
            set;
        }
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

