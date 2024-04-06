/////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Audiokinetic Wwise generated include file. Do not edit.
//
/////////////////////////////////////////////////////////////////////////////////////////////////////

#ifndef __WWISE_IDS_H__
#define __WWISE_IDS_H__

#include <AK/SoundEngine/Common/AkTypes.h>

namespace AK
{
    namespace EVENTS
    {
        static const AkUniqueID BGM = 412724365U;
        static const AkUniqueID DOORCREAK = 227958399U;
        static const AkUniqueID DOOROPEN = 1404805401U;
        static const AkUniqueID DOORUNLOCK = 1553818165U;
        static const AkUniqueID KEYPADFAIL = 2411561249U;
        static const AkUniqueID KEYPADPRESSED = 2108322741U;
        static const AkUniqueID KEYPADSUCCESS = 2353527262U;
        static const AkUniqueID LANTERNPICKUP = 1546523411U;
        static const AkUniqueID LANTERNTHUD = 2165330516U;
        static const AkUniqueID PLAY = 1256202815U;
        static const AkUniqueID START = 1281810935U;
        static const AkUniqueID WALKINGSTONE = 881533257U;
    } // namespace EVENTS

    namespace STATES
    {
        namespace INGAME
        {
            static const AkUniqueID GROUP = 984691642U;

            namespace STATE
            {
                static const AkUniqueID INGAME = 984691642U;
                static const AkUniqueID LEVELTRANSITION = 4198606512U;
                static const AkUniqueID NONE = 748895195U;
            } // namespace STATE
        } // namespace INGAME

        namespace MAIN
        {
            static const AkUniqueID GROUP = 3161908922U;

            namespace STATE
            {
                static const AkUniqueID IDELINMAINMENU = 2707144702U;
                static const AkUniqueID STARTINGGAME = 1300063251U;
            } // namespace STATE
        } // namespace MAIN

    } // namespace STATES

    namespace SWITCHES
    {
        namespace FOOTSTEPS
        {
            static const AkUniqueID GROUP = 2385628198U;

            namespace SWITCH
            {
                static const AkUniqueID STONE = 1216965916U;
            } // namespace SWITCH
        } // namespace FOOTSTEPS

    } // namespace SWITCHES

    namespace TRIGGERS
    {
        static const AkUniqueID NEW_TRIGGER = 4163741908U;
    } // namespace TRIGGERS

    namespace BANKS
    {
        static const AkUniqueID INIT = 1355168291U;
        static const AkUniqueID DOORCREAK = 227958399U;
        static const AkUniqueID DOOROPEN = 1404805401U;
        static const AkUniqueID DOORUNLOCK = 1553818165U;
        static const AkUniqueID INGAMEBGM = 1893515252U;
        static const AkUniqueID KEYPADFAIL = 2411561249U;
        static const AkUniqueID KEYPADPRESSED = 2108322741U;
        static const AkUniqueID KEYPADSUCCESS = 2353527262U;
        static const AkUniqueID LANTERNPICKUP = 1546523411U;
        static const AkUniqueID LANTERNTHUD = 2165330516U;
        static const AkUniqueID STARTBUTTON = 1651515387U;
        static const AkUniqueID TITLEMUSIC = 2191159630U;
        static const AkUniqueID WALKINGSTONE = 881533257U;
    } // namespace BANKS

    namespace BUSSES
    {
        static const AkUniqueID MASTER_AUDIO_BUS = 3803692087U;
    } // namespace BUSSES

    namespace AUDIO_DEVICES
    {
        static const AkUniqueID NO_OUTPUT = 2317455096U;
        static const AkUniqueID SYSTEM = 3859886410U;
    } // namespace AUDIO_DEVICES

}// namespace AK

#endif // __WWISE_IDS_H__
