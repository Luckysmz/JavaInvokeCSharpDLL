#region CLR�汾 4.0.30319.239
// ElementBuildType ��
// ʱ�䣺2012-3-16 10:50:22
// ���ƣ�ElementBuildType
// ��٣�Ԫ����������
//
// �����ˣ�����
// ��Ȩ��Copyright (C) 2012 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDQS.Contracts
{
    /// <summary>
    /// Ԫ����������
    /// </summary>
    public enum ElementBuildType
    {
        /// <summary>
        /// ���ݿⷽʽ
        /// </summary>
        DataBase,
        /// <summary>
        /// �����ļ�
        /// </summary>
        Config,
        /// <summary>
        /// ��װ�����ݿ⣬��װ�������ļ�
        /// </summary>
        DataBaseAndConfig

    }
}