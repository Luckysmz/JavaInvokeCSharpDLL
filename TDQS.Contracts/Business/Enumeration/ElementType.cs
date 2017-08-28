#region CLR�汾 4.0.30319.239
// ElementType ��
// ʱ�䣺2011-11-9 17:54:55
// ���ƣ�ElementType ��
// ��٣�Ԫ������
//
// �����ˣ�����
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace TDQS.Contracts
{
    /// <summary>
    /// Ԫ������
    /// </summary>
    public enum ElementType : byte
    {
        /// <summary>
        /// δ֪
        /// </summary>
        Unknown,

        /// <summary>
        /// �ڵ�
        /// </summary>
        Node = 1,

        /// <summary>
        /// ���ӵ�
        /// </summary>
        ConnectionNode = 2,

        /// <summary>
        /// �߶�
        /// </summary>
        Line = 4,

        /// <summary>
        /// ����ѹ��
        /// </summary>
        DistributionTransformer = 5,

        /// <summary>
        /// ����
        /// </summary>
        Switch = 6,

        /// <summary>
        /// ���վ
        /// </summary>
        Substation = 8,

        /// <summary>
        /// ������
        /// </summary>
        RingMainUnit = 9,

        /// <summary>
        /// ���߶���
        /// </summary>
        FeederNode = 10,

        /// <summary>
        /// ĸ��
        /// </summary>
        BusBarSection = 12,

        /// <summary>
        /// ���վ վ��ĸ��
        /// </summary>
        SubstationBusBar = 13,

        /// <summary>
        /// ����վ
        /// </summary>
        SwitchStation = 14,

        /// <summary>
        /// �����
        /// </summary>
        DoubleWTransformer = 15,

        /// <summary>
        /// �����
        /// </summary>
        ThreeWTransformer = 16,

        /// <summary>
        /// ��ֵ��
        /// </summary>
        IsoNode = 20,

        /// <summary>
        /// ������
        /// </summary>
        Connector = 21,

        /// <summary>
        /// ĸ�����翪��
        /// </summary>
        BusTieSwitch = 22,

        /// <summary>
        /// �����������
        /// </summary>
        SwitchTerminal = 23,

        /// <summary>
        /// �����
        /// </summary>
        DistributionRoom = 25,

        /// <summary>
        /// ��ʽվ
        /// </summary>
        BoxSubstation = 26,

        /// <summary>
        /// ��֧��
        /// </summary>
        BranchBox = 27,

        /// <summary>
        /// ����
        /// </summary>
        Load = 30,

        /// <summary>
        /// �����
        /// </summary>
        Generator = 31,

        //���վģ�͸��� ����� 2008-1-31
        /// <summary>
        /// ��ѹ���վ
        /// </summary>
        HighVoltageSubstation = 32,


        /// <summary>
        /// ����
        /// </summary>
        WideArea = 40,

        /// <summary>
        /// ����
        /// </summary>
        MidArea = 41,

        /// <summary>
        /// С��
        /// </summary>
        SmallArea = 42,

        /// <summary>
        /// ��������
        /// </summary>
        MidAreaLoad = 43,

        /// <summary>
        /// С������
        /// </summary>
        SmallAreaLoad = 44,

        /// <summary>
        /// �㸺��
        /// </summary>
        DotLoad = 45,

        /// <summary>
        /// ����
        /// </summary>
        SubArea = 46,

        /// <summary>
        /// �ּ�����
        /// </summary>
        HierachicalArea = 47,

        /// <summary>
        /// ����
        /// </summary>
        PipeLine = 50,

        /// <summary>
        /// ���¾�
        /// </summary>
        CableDrawPit = 51,

        /// <summary>
        /// ���μ��Ż��͵�վ
        /// </summary>
        UnConstructedTransmissionSubstation = 52,

        /// <summary>
        /// ���
        /// </summary>
        Tunnel = 53,

        /// <summary>
        /// ���¹�
        /// </summary>
        CableTunnel = 54,

        /// <summary>
        /// �ն˳�
        /// </summary>
        Terminal = 55,

        /// <summary>
        /// �滮���Ƶ�������
        /// </summary>
        CableCorridor = 56,

        /// <summary>
        /// ���糧
        /// </summary>
        PowerPlant = 57,

        /// <summary>
        /// ֱ�����
        /// </summary>
        DirectBurialCable = 58,

        /// <summary>
        /// �½����վ
        /// </summary>
        NewSubstation500 = 60,
        NewSubstation220 = 61,
        NewSubstation110 = 62,

        /// <summary>
        /// ���б��վ
        /// </summary>
        ExistingSubstation500 = 63,
        ExistingSubstation220 = 64,
        ExistingSubstation110 = 65,

        /// <summary>
        /// ĸ��
        /// ����:2008.06.09 ��Ӻ�޸�
        /// </summary>
        BusBarSwitch = 80,
        /// <summary>
        /// ĸ������
        /// ����:2008.06.09 ��Ӻ�޸�
        /// </summary>
        BusBarSwitchTerminal = 81,

        /// <summary>
        /// ����
        /// </summary>
        ElectrifiedNetwork = 100,

        /// <summary>
        /// ����
        /// </summary>
        FeederLine = 101,

        /// <summary>
        /// ƽ��ڵ�
        /// </summary>
        BalancingBus = 102,

        /// <summary>
        /// �������
        /// </summary>
        PowerSS = 103,

        /// <summary>
        /// ��������
        /// </summary>
        AdministrativeD = 104,

        /// <summary>
        /// �����Դ
        /// </summary>
        PVPowerBoard = 105,

        /// <summary>
        /// �����ֵ����
        /// </summary>
        PVLoad = 106,

        /// <summary>
        /// �������ģ��
        /// </summary>
        PVAccessModule = 107,

        /// <summary>
        /// �����翹��
        /// </summary>
        ShuntReactor = 108,

        /// <summary>
        /// ����������
        /// </summary>
        ShuntCapacitor = 109,

        /// <summary>
        /// ��Դ����
        /// </summary>
        DNASElectricSwitch = 110,

        /// <summary>
        /// �����翹��
        /// </summary>
        SeriesReactor = 150,//���� 2013-12-09	
        /// <summary>
        /// ����������
        /// </summary>
        SeriesCapacitor = 151,//���� 2013-12-09

        /// <summary>
        /// ��Դ����
        /// </summary>
        dnas_fh = 111,

        /// <summary>
        /// ��Դƽ��ڵ� 
        /// </summary>
        dnas_phjd = 112,

        /// <summary>
        /// ��Դֱ������Դ
        /// </summary>
        dnas_zldly = 113,

        /// <summary>
        /// ��ԴPI�ڵ�
        /// </summary>
        dnas_pijd = 114,

        /// <summary>
        /// ��Դ������ 
        /// </summary>
        dnas_drq = 115,

        /// <summary>
        /// ��ԴPV�ڵ�
        /// </summary>
        dnas_pvjd = 116,

        /// <summary>
        /// ��ԴPQ�ڵ�
        /// </summary>
        dnas_pqjd = 117,

        /// <summary>
        /// ��ԴPQV�ڵ�
        /// </summary>
        dnas_pqvjd = 118,

        /// <summary>
        /// ��Դ��ѹ��
        /// </summary>
        dnas_byq = 119,

        /// <summary>
        /// ������
        /// </summary>
        dnas_hlq = 120,

        /// <summary>
        /// ֱ����·
        /// </summary>
        dnas_zlxl = 121,

        /// <summary>
        /// ������·
        /// </summary>
        dnas_jlxl = 122,

        /// <summary>
        /// ��Դ������
        /// </summary>
        dnas_ljx = 123,

        /// <summary>
        /// ����ĸ��
        /// </summary>
        dnas_jlmx = 124,

        /// <summary>
        /// ֱ��ĸ��
        /// </summary>
        dnas_zlmx = 125,

        /// <summary>
        ///  ͬ�����
        /// </summary>
        dnas_tbdj = 126,

        /// <summary>
        /// �첽���
        /// </summary>
        dnas_ybdj = 127,

        /// <summary>
        /// ������
        /// </summary>
        dnas_gfdch = 128,

        /// <summary>
        /// ���ɿ���
        /// </summary>
        dnas_fhkg = 129,

        /// <summary>
        /// ���뿪��
        /// </summary>
        dnas_glkg = 130,

        /// <summary>
        /// ͬ�����_����
        /// </summary>
        dnas_tbdj_test = 131,

        /// <summary>
        /// �첽���_����
        /// </summary>
        dnas_ybdj_test = 132,

        /// <summary>
        /// ������_����
        /// </summary>
        dnas_gfdch_test = 133,

        /// <summary>
        /// ������·��
        /// </summary>
        dnas_jldlq = 134,

        /// <summary>
        /// �������뿪��
        /// </summary>
        dnas_jlglkg = 135,

        // ���ͽ���Ԫ�� ���� 2013-9-17
        /// <summary>
        /// ���ͽ���
        /// </summary>
        GroupDevice = 201,

        /// <summary>
        /// ����������
        /// </summary>
        dnas_ljx_jl = 136,

        /// <summary>
        /// ��������
        /// </summary>
        dnas_fh_jl = 137,

        /// <summary>
        /// �����
        /// </summary>
        DistributionTransformer_New = 138,

        // ���, 2013/8/29 9:44:02, ��ӣ�������Ԫ�� ��ѹ�����Դ��PVPowerBoardLow��
        /// <summary>
        /// ��ѹ�����Դ
        /// </summary>
        PVPowerBoardLow = 139,

        /// <summary>
        /// ������Ϣģ��
        /// </summary>
        dnas_geographicinfo=140,
        /// <summary>
        /// ��Դϵͳ�������ѹ��
        /// </summary>
        dnas_3byq=141,

        /// <summary>
        /// �翹��
        /// </summary>
        dnas_dkq=142,
        /// <summary>
        /// ���ϵͳ
        /// </summary>
        dnas_pvsystem =143,

        /// <summary>
        /// ���������
        /// </summary>
        dnas_windfdj = 144,

        /// <summary>
        /// ��ȼ��
        /// </summary>
        dnas_combustionengine = 145,

        //2014-10-23 13:33:29 ���� ��� ����ģ�ͣ����׮���任��վ �½���Ԫ�����
        /// <summary>
        /// ����ģ��
        /// </summary>
        Storage = 146,

        /// <summary>
        /// ���׮
        /// </summary>
        Chargingpile = 147,

        /// <summary>
        /// �任��վ
        /// </summary>
        Fillingstation = 148,


        End

    }

}