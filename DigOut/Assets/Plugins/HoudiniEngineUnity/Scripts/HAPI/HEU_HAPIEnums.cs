/*
* Copyright (c) <2021> Side Effects Software Inc.
*
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
*
* The above copyright notice and this permission notice shall be included in all
* copies or substantial portions of the Software.
*
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
* SOFTWARE.
*
* Produced by:
*      Side Effects Software Inc
*      123 Front Street West, Suite 1401
*      Toronto, Ontario
*      Canada   M5J 2M2
*      416-504-9876
*/


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// WARNING! This file is automatically GENERATED.
// DO NOT modify manually or commit to the repository!
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;

namespace HoudiniEngineUnity
{
    using HAPI_Bool = System.Boolean;
    using HAPI_UInt8 = System.Byte;
    using HAPI_Int8 = System.SByte;
    using HAPI_Int16 = System.Int16;
    using HAPI_Int64 = System.Int64;
    using HAPI_ProcessId = System.Int32;
    using HAPI_SessionId = System.Int64;
    using HAPI_StringHandle = System.Int32;
    using HAPI_AssetLibraryId = System.Int32;
    using HAPI_NodeId = System.Int32;
    using HAPI_ParmId = System.Int32;
    using HAPI_PartId = System.Int32;
    using HAPI_PDG_WorkitemId = System.Int32;
    using HAPI_PDG_GraphContextId = System.Int32;
    using HAPI_HIPFileId = System.Int32;
    using HAPI_ErrorCodeBits = System.Int32;
    using HAPI_NodeTypeBits = System.Int32;
    using HAPI_NodeFlagsBits = System.Int32;

    public enum HAPI_License          
    {
        HAPI_LICENSE_NONE,        
        HAPI_LICENSE_HOUDINI_ENGINE,        
        HAPI_LICENSE_HOUDINI,        
        HAPI_LICENSE_HOUDINI_FX,        
        HAPI_LICENSE_HOUDINI_ENGINE_INDIE,        
        HAPI_LICENSE_HOUDINI_INDIE,        
        HAPI_LICENSE_HOUDINI_ENGINE_UNITY_UNREAL,        
        HAPI_LICENSE_MAX,        
    };

    public enum HAPI_StatusType          
    {
        HAPI_STATUS_CALL_RESULT,        
        HAPI_STATUS_COOK_RESULT,        
        HAPI_STATUS_COOK_STATE,        
        HAPI_STATUS_MAX,        
    };

    public enum HAPI_StatusVerbosity          
    {
        HAPI_STATUSVERBOSITY_0,        
        HAPI_STATUSVERBOSITY_1,        
        HAPI_STATUSVERBOSITY_2,        
        HAPI_STATUSVERBOSITY_ALL = HAPI_STATUSVERBOSITY_2,        //Used for Results. Equivalent to HAPI_STATUSVERBOSITY_2
        HAPI_STATUSVERBOSITY_ERRORS = HAPI_STATUSVERBOSITY_0,        //Used for Results. Equivalent to HAPI_STATUSVERBOSITY_0
        HAPI_STATUSVERBOSITY_WARNINGS = HAPI_STATUSVERBOSITY_1,        //Used for Results. Equivalent to HAPI_STATUSVERBOSITY_1
        HAPI_STATUSVERBOSITY_MESSAGES = HAPI_STATUSVERBOSITY_2,        //Used for Results. Equivalent to HAPI_STATUSVERBOSITY_2
    };

    public enum HAPI_Result          
    {
        HAPI_RESULT_SUCCESS = 0,        
        HAPI_RESULT_FAILURE = 1,        
        HAPI_RESULT_ALREADY_INITIALIZED = 2,        
        HAPI_RESULT_NOT_INITIALIZED = 3,        
        HAPI_RESULT_CANT_LOADFILE = 4,        
        HAPI_RESULT_PARM_SET_FAILED = 5,        
        HAPI_RESULT_INVALID_ARGUMENT = 6,        
        HAPI_RESULT_CANT_LOAD_GEO = 7,        
        HAPI_RESULT_CANT_GENERATE_PRESET = 8,        
        HAPI_RESULT_CANT_LOAD_PRESET = 9,        
        HAPI_RESULT_ASSET_DEF_ALREADY_LOADED = 10,        
        HAPI_RESULT_NO_LICENSE_FOUND = 110,        
        HAPI_RESULT_DISALLOWED_NC_LICENSE_FOUND = 120,        
        HAPI_RESULT_DISALLOWED_NC_ASSET_WITH_C_LICENSE = 130,        
        HAPI_RESULT_DISALLOWED_NC_ASSET_WITH_LC_LICENSE = 140,        
        HAPI_RESULT_DISALLOWED_LC_ASSET_WITH_C_LICENSE = 150,        
        HAPI_RESULT_DISALLOWED_HENGINEINDIE_W_3PARTY_PLUGIN = 160,        
        HAPI_RESULT_ASSET_INVALID = 200,        
        HAPI_RESULT_NODE_INVALID = 210,        
        HAPI_RESULT_USER_INTERRUPTED = 300,        
        HAPI_RESULT_INVALID_SESSION = 400,        
    };

    [Flags]
    public enum HAPI_ErrorCode          
    {
        HAPI_ERRORCODE_ASSET_DEF_NOT_FOUND = 1 << 0,        
        HAPI_ERRORCODE_PYTHON_NODE_ERROR = 1 << 1,        
    };

    public enum HAPI_SessionType          
    {
        HAPI_SESSION_INPROCESS,        
        HAPI_SESSION_THRIFT,        
        HAPI_SESSION_CUSTOM1,        
        HAPI_SESSION_CUSTOM2,        
        HAPI_SESSION_CUSTOM3,        
        HAPI_SESSION_MAX,        
    };

    public enum HAPI_State          
    {
        HAPI_STATE_READY,        //Everything cook successfully without errors
        HAPI_STATE_READY_WITH_FATAL_ERRORS,        //You should abort the cook.
        HAPI_STATE_READY_WITH_COOK_ERRORS,        //Only some objects failed.
        HAPI_STATE_STARTING_COOK,        
        HAPI_STATE_COOKING,        
        HAPI_STATE_STARTING_LOAD,        
        HAPI_STATE_LOADING,        
        HAPI_STATE_MAX,        
        HAPI_STATE_MAX_READY_STATE = HAPI_STATE_READY_WITH_COOK_ERRORS,        
    };

    public enum HAPI_PackedPrimInstancingMode          
    {
        HAPI_PACKEDPRIM_INSTANCING_MODE_INVALID = -1,        
        HAPI_PACKEDPRIM_INSTANCING_MODE_DISABLED,        
        HAPI_PACKEDPRIM_INSTANCING_MODE_HIERARCHY,        
        HAPI_PACKEDPRIM_INSTANCING_MODE_FLAT,        
        HAPI_PACKEDPRIM_INSTANCING_MODE_MAX,        
    };

    public enum HAPI_Permissions          
    {
        HAPI_PERMISSIONS_NON_APPLICABLE,        
        HAPI_PERMISSIONS_READ_WRITE,        
        HAPI_PERMISSIONS_READ_ONLY,        
        HAPI_PERMISSIONS_WRITE_ONLY,        
        HAPI_PERMISSIONS_MAX,        
    };

    public enum HAPI_RampType          
    {
        HAPI_RAMPTYPE_INVALID = -1,        
        HAPI_RAMPTYPE_FLOAT,        
        HAPI_RAMPTYPE_COLOR,        
        HAPI_RAMPTYPE_MAX,        
    };

    public enum HAPI_ParmType          //Represents the data type of a parm.As you can see some of these high level types share the same underlyingraw data type. For instance both string and file parameter types can berepresented with strings yet semantically they are different. We willgroup high level parameter types that share an underlying raw data typetogether so you can always check the raw data type of a parameter basedon its high level data type by checking a range of values.
    {
        HAPI_PARMTYPE_INT = 0,        //@{
        HAPI_PARMTYPE_MULTIPARMLIST,        
        HAPI_PARMTYPE_TOGGLE,        
        HAPI_PARMTYPE_BUTTON,        
        HAPI_PARMTYPE_FLOAT,        //@{
        HAPI_PARMTYPE_COLOR,        
        HAPI_PARMTYPE_STRING,        //@{
        HAPI_PARMTYPE_PATH_FILE,        
        HAPI_PARMTYPE_PATH_FILE_GEO,        
        HAPI_PARMTYPE_PATH_FILE_IMAGE,        
        HAPI_PARMTYPE_NODE,        
        HAPI_PARMTYPE_FOLDERLIST,        //@{
        HAPI_PARMTYPE_FOLDERLIST_RADIO,        
        HAPI_PARMTYPE_FOLDER,        //@{
        HAPI_PARMTYPE_LABEL,        
        HAPI_PARMTYPE_SEPARATOR,        
        HAPI_PARMTYPE_PATH_FILE_DIR,        
        HAPI_PARMTYPE_MAX,        //Total number of supported parameter types.
        HAPI_PARMTYPE_INT_START = HAPI_PARMTYPE_INT,        
        HAPI_PARMTYPE_INT_END = HAPI_PARMTYPE_BUTTON,        
        HAPI_PARMTYPE_FLOAT_START = HAPI_PARMTYPE_FLOAT,        
        HAPI_PARMTYPE_FLOAT_END = HAPI_PARMTYPE_COLOR,        
        HAPI_PARMTYPE_STRING_START = HAPI_PARMTYPE_STRING,        
        HAPI_PARMTYPE_STRING_END = HAPI_PARMTYPE_NODE,        
        HAPI_PARMTYPE_PATH_START = HAPI_PARMTYPE_PATH_FILE,        
        HAPI_PARMTYPE_PATH_END = HAPI_PARMTYPE_PATH_FILE_IMAGE,        
        HAPI_PARMTYPE_NODE_START = HAPI_PARMTYPE_NODE,        
        HAPI_PARMTYPE_NODE_END = HAPI_PARMTYPE_NODE,        
        HAPI_PARMTYPE_CONTAINER_START = HAPI_PARMTYPE_FOLDERLIST,        
        HAPI_PARMTYPE_CONTAINER_END = HAPI_PARMTYPE_FOLDERLIST_RADIO,        
        HAPI_PARMTYPE_NONVALUE_START = HAPI_PARMTYPE_FOLDER,        
        HAPI_PARMTYPE_NONVALUE_END = HAPI_PARMTYPE_SEPARATOR,        
    };

    public enum HAPI_PrmScriptType          //Corresponds to the types as shown in the Houdini Type Propertieswindow and in DialogScript files. Available on HAPI_ParmInfoSee: <a href="http://www.sidefx.com/docs/houdini/ref/windows/optype.html#parmtypes">Parameter types</a>
    {
        HAPI_PRM_SCRIPT_TYPE_INT = 0,        //"int" "integer"
        HAPI_PRM_SCRIPT_TYPE_FLOAT,        
        HAPI_PRM_SCRIPT_TYPE_ANGLE,        
        HAPI_PRM_SCRIPT_TYPE_STRING,        
        HAPI_PRM_SCRIPT_TYPE_FILE,        
        HAPI_PRM_SCRIPT_TYPE_DIRECTORY,        
        HAPI_PRM_SCRIPT_TYPE_IMAGE,        
        HAPI_PRM_SCRIPT_TYPE_GEOMETRY,        
        HAPI_PRM_SCRIPT_TYPE_TOGGLE,        //"toggle" "embed"
        HAPI_PRM_SCRIPT_TYPE_BUTTON,        
        HAPI_PRM_SCRIPT_TYPE_VECTOR2,        
        HAPI_PRM_SCRIPT_TYPE_VECTOR3,        //"vector" "vector3"
        HAPI_PRM_SCRIPT_TYPE_VECTOR4,        
        HAPI_PRM_SCRIPT_TYPE_INTVECTOR2,        
        HAPI_PRM_SCRIPT_TYPE_INTVECTOR3,        //"intvector" "intvector3"
        HAPI_PRM_SCRIPT_TYPE_INTVECTOR4,        
        HAPI_PRM_SCRIPT_TYPE_UV,        
        HAPI_PRM_SCRIPT_TYPE_UVW,        
        HAPI_PRM_SCRIPT_TYPE_DIR,        //"dir" "direction"
        HAPI_PRM_SCRIPT_TYPE_COLOR,        //"color" "rgb"
        HAPI_PRM_SCRIPT_TYPE_COLOR4,        //"color4" "rgba"
        HAPI_PRM_SCRIPT_TYPE_OPPATH,        
        HAPI_PRM_SCRIPT_TYPE_OPLIST,        
        HAPI_PRM_SCRIPT_TYPE_OBJECT,        
        HAPI_PRM_SCRIPT_TYPE_OBJECTLIST,        
        HAPI_PRM_SCRIPT_TYPE_RENDER,        
        HAPI_PRM_SCRIPT_TYPE_SEPARATOR,        
        HAPI_PRM_SCRIPT_TYPE_GEOMETRY_DATA,        
        HAPI_PRM_SCRIPT_TYPE_KEY_VALUE_DICT,        
        HAPI_PRM_SCRIPT_TYPE_LABEL,        
        HAPI_PRM_SCRIPT_TYPE_RGBAMASK,        
        HAPI_PRM_SCRIPT_TYPE_ORDINAL,        
        HAPI_PRM_SCRIPT_TYPE_RAMP_FLT,        
        HAPI_PRM_SCRIPT_TYPE_RAMP_RGB,        
        HAPI_PRM_SCRIPT_TYPE_FLOAT_LOG,        
        HAPI_PRM_SCRIPT_TYPE_INT_LOG,        
        HAPI_PRM_SCRIPT_TYPE_DATA,        
        HAPI_PRM_SCRIPT_TYPE_FLOAT_MINMAX,        
        HAPI_PRM_SCRIPT_TYPE_INT_MINMAX,        
        HAPI_PRM_SCRIPT_TYPE_INT_STARTEND,        
        HAPI_PRM_SCRIPT_TYPE_BUTTONSTRIP,        
        HAPI_PRM_SCRIPT_TYPE_ICONSTRIP,        
        HAPI_PRM_SCRIPT_TYPE_GROUPRADIO = 1000,        //The following apply to HAPI_PARMTYPE_FOLDER type parms.Radio buttons Folder
        HAPI_PRM_SCRIPT_TYPE_GROUPCOLLAPSIBLE,        //Collapsible Folder
        HAPI_PRM_SCRIPT_TYPE_GROUPSIMPLE,        //Simple Folder
        HAPI_PRM_SCRIPT_TYPE_GROUP,        //Tabs Folder
    };

    public enum HAPI_ChoiceListType          
    {
        HAPI_CHOICELISTTYPE_NONE,        //Parameter is not a menu
        HAPI_CHOICELISTTYPE_NORMAL,        //Menu Only Single Selection
        HAPI_CHOICELISTTYPE_MINI,        //Mini Menu Only Single Selection
        HAPI_CHOICELISTTYPE_REPLACE,        //Field + Single Selection Menu
        HAPI_CHOICELISTTYPE_TOGGLE,        //Field + Multiple Selection Menu
    };

    public enum HAPI_PresetType          
    {
        HAPI_PRESETTYPE_INVALID = -1,        
        HAPI_PRESETTYPE_BINARY = 0,        //Just the presets binary blob
        HAPI_PRESETTYPE_IDX,        //Presets blob within an .idx file format
        HAPI_PRESETTYPE_MAX,        
    };

    [Flags]
    public enum HAPI_NodeType          
    {
        HAPI_NODETYPE_ANY = -1,        
        HAPI_NODETYPE_NONE = 0,        
        HAPI_NODETYPE_OBJ = 1 << 0,        
        HAPI_NODETYPE_SOP = 1 << 1,        
        HAPI_NODETYPE_CHOP = 1 << 2,        
        HAPI_NODETYPE_ROP = 1 << 3,        
        HAPI_NODETYPE_SHOP = 1 << 4,        
        HAPI_NODETYPE_COP = 1 << 5,        
        HAPI_NODETYPE_VOP = 1 << 6,        
        HAPI_NODETYPE_DOP = 1 << 7,        
        HAPI_NODETYPE_TOP = 1 << 8,        
    };

    [Flags]
    public enum HAPI_NodeFlags          //Flags used to filter compositions of node lists.Flags marked  Flag will exclude children whos parent does notsatisfy the flag even if the children themselves satisfy the flag.
    {
        HAPI_NODEFLAGS_ANY = -1,        
        HAPI_NODEFLAGS_NONE = 0,        
        HAPI_NODEFLAGS_DISPLAY = 1 << 0,        //Recursive Flag
        HAPI_NODEFLAGS_RENDER = 1 << 1,        //Recursive Flag
        HAPI_NODEFLAGS_TEMPLATED = 1 << 2,        
        HAPI_NODEFLAGS_LOCKED = 1 << 3,        
        HAPI_NODEFLAGS_EDITABLE = 1 << 4,        
        HAPI_NODEFLAGS_BYPASS = 1 << 5,        
        HAPI_NODEFLAGS_NETWORK = 1 << 6,        
        HAPI_NODEFLAGS_OBJ_GEOMETRY = 1 << 7,        //OBJ Node Specific Flags
        HAPI_NODEFLAGS_OBJ_CAMERA = 1 << 8,        
        HAPI_NODEFLAGS_OBJ_LIGHT = 1 << 9,        
        HAPI_NODEFLAGS_OBJ_SUBNET = 1 << 10,        
        HAPI_NODEFLAGS_SOP_CURVE = 1 << 11,        //SOP Node Specific FlagsLooks for "curve"
        HAPI_NODEFLAGS_SOP_GUIDE = 1 << 12,        //Looks for Guide Geometry
        HAPI_NODEFLAGS_TOP_NONSCHEDULER = 1 << 13,        //TOP Node Specific FlagsAll TOP nodes except schedulers
        HAPI_NODEFLAGS_NON_BYPASS = 1 << 14 ,        //Nodes that are not bypassed
    };

    public enum HAPI_GroupType          
    {
        HAPI_GROUPTYPE_INVALID = -1,        
        HAPI_GROUPTYPE_POINT,        
        HAPI_GROUPTYPE_PRIM,        
        HAPI_GROUPTYPE_EDGE,        
        HAPI_GROUPTYPE_MAX,        
    };

    public enum HAPI_AttributeOwner          
    {
        HAPI_ATTROWNER_INVALID = -1,        
        HAPI_ATTROWNER_VERTEX,        
        HAPI_ATTROWNER_POINT,        
        HAPI_ATTROWNER_PRIM,        
        HAPI_ATTROWNER_DETAIL,        
        HAPI_ATTROWNER_MAX,        
    };

    public enum HAPI_CurveType          
    {
        HAPI_CURVETYPE_INVALID = -1,        
        HAPI_CURVETYPE_LINEAR,        
        HAPI_CURVETYPE_NURBS,        
        HAPI_CURVETYPE_BEZIER,        
        HAPI_CURVETYPE_MAX,        
    };

    public enum HAPI_InputCurveMethod          
    {
        HAPI_CURVEMETHOD_INVALID = -1,        
        HAPI_CURVEMETHOD_CVS,        
        HAPI_CURVEMETHOD_BREAKPOINTS,        
        HAPI_CURVEMETHOD_MAX,        
    };

    public enum HAPI_InputCurveParameterization          
    {
        HAPI_CURVEPARAMETERIZATION_INVALID = -1,        
        HAPI_CURVEPARAMETERIZATION_UNIFORM,        
        HAPI_CURVEPARAMETERIZATION_CHORD,        
        HAPI_CURVEPARAMETERIZATION_CENTRIPETAL,        
        HAPI_CURVEPARAMETERIZATION_MAX,        
    };

    public enum HAPI_VolumeType          
    {
        HAPI_VOLUMETYPE_INVALID = -1,        
        HAPI_VOLUMETYPE_HOUDINI,        
        HAPI_VOLUMETYPE_VDB,        
        HAPI_VOLUMETYPE_MAX,        
    };

    public enum HAPI_VolumeVisualType          
    {
        HAPI_VOLUMEVISTYPE_INVALID = -1,        
        HAPI_VOLUMEVISTYPE_SMOKE,        
        HAPI_VOLUMEVISTYPE_RAINBOW,        
        HAPI_VOLUMEVISTYPE_ISO,        
        HAPI_VOLUMEVISTYPE_INVISIBLE,        
        HAPI_VOLUMEVISTYPE_HEIGHTFIELD,        
        HAPI_VOLUMEVISTYPE_MAX,        
    };

    public enum HAPI_StorageType          
    {
        HAPI_STORAGETYPE_INVALID = -1,        
        HAPI_STORAGETYPE_INT,        
        HAPI_STORAGETYPE_INT64,        
        HAPI_STORAGETYPE_FLOAT,        
        HAPI_STORAGETYPE_FLOAT64,        
        HAPI_STORAGETYPE_STRING,        
        HAPI_STORAGETYPE_UINT8,        
        HAPI_STORAGETYPE_INT8,        
        HAPI_STORAGETYPE_INT16,        
        HAPI_STORAGETYPE_INT_ARRAY,        
        HAPI_STORAGETYPE_INT64_ARRAY,        
        HAPI_STORAGETYPE_FLOAT_ARRAY,        
        HAPI_STORAGETYPE_FLOAT64_ARRAY,        
        HAPI_STORAGETYPE_STRING_ARRAY,        
        HAPI_STORAGETYPE_UINT8_ARRAY,        
        HAPI_STORAGETYPE_INT8_ARRAY,        
        HAPI_STORAGETYPE_INT16_ARRAY,        
        HAPI_STORAGETYPE_MAX,        
    };

    public enum HAPI_AttributeTypeInfo          
    {
        HAPI_ATTRIBUTE_TYPE_INVALID = -1,        
        HAPI_ATTRIBUTE_TYPE_NONE,        //Implicit type based on data
        HAPI_ATTRIBUTE_TYPE_POINT,        //Position
        HAPI_ATTRIBUTE_TYPE_HPOINT,        //Homogeneous position
        HAPI_ATTRIBUTE_TYPE_VECTOR,        //Direction vector
        HAPI_ATTRIBUTE_TYPE_NORMAL,        //Normal
        HAPI_ATTRIBUTE_TYPE_COLOR,        //Color
        HAPI_ATTRIBUTE_TYPE_QUATERNION,        //Quaternion
        HAPI_ATTRIBUTE_TYPE_MATRIX3,        //3x3 Matrix
        HAPI_ATTRIBUTE_TYPE_MATRIX,        //Matrix
        HAPI_ATTRIBUTE_TYPE_ST,        //Parametric interval
        HAPI_ATTRIBUTE_TYPE_HIDDEN,        //"Private" hidden
        HAPI_ATTRIBUTE_TYPE_BOX2,        //2x2 Bounding box
        HAPI_ATTRIBUTE_TYPE_BOX,        //3x3 Bounding box
        HAPI_ATTRIBUTE_TYPE_TEXTURE,        //Texture coordinate
        HAPI_ATTRIBUTE_TYPE_MAX,        
    };

    public enum HAPI_GeoType          
    {
        HAPI_GEOTYPE_INVALID = -1,        
        HAPI_GEOTYPE_DEFAULT,        //Most geos will be of this type which essentially means a geonot of the other types.
        HAPI_GEOTYPE_INTERMEDIATE,        //An exposed edit node.See HAPI_IntermediateAssetsResults.
        HAPI_GEOTYPE_INPUT,        //An input geo that can accept geometry from the host.See HAPI_AssetInputs_MarshallingGeometryIntoHoudini.
        HAPI_GEOTYPE_CURVE,        //A curve.See HAPI_Curves.
        HAPI_GEOTYPE_MAX,        
    };

    public enum HAPI_PartType          
    {
        HAPI_PARTTYPE_INVALID = -1,        
        HAPI_PARTTYPE_MESH,        
        HAPI_PARTTYPE_CURVE,        
        HAPI_PARTTYPE_VOLUME,        
        HAPI_PARTTYPE_INSTANCER,        
        HAPI_PARTTYPE_BOX,        
        HAPI_PARTTYPE_SPHERE,        
        HAPI_PARTTYPE_MAX,        
    };

    public enum HAPI_InputType          
    {
        HAPI_INPUT_INVALID = -1,        
        HAPI_INPUT_TRANSFORM,        
        HAPI_INPUT_GEOMETRY,        
        HAPI_INPUT_MAX,        
    };

    public enum HAPI_CurveOrders          
    {
        HAPI_CURVE_ORDER_VARYING = 0,        
        HAPI_CURVE_ORDER_INVALID = 1,        
        HAPI_CURVE_ORDER_LINEAR = 2,        
        HAPI_CURVE_ORDER_QUADRATIC = 3,        
        HAPI_CURVE_ORDER_CUBIC = 4,        
    };

    public enum HAPI_TransformComponent          
    {
        HAPI_TRANSFORM_TX = 0,        
        HAPI_TRANSFORM_TY,        
        HAPI_TRANSFORM_TZ,        
        HAPI_TRANSFORM_RX,        
        HAPI_TRANSFORM_RY,        
        HAPI_TRANSFORM_RZ,        
        HAPI_TRANSFORM_QX,        
        HAPI_TRANSFORM_QY,        
        HAPI_TRANSFORM_QZ,        
        HAPI_TRANSFORM_QW,        
        HAPI_TRANSFORM_SX,        
        HAPI_TRANSFORM_SY,        
        HAPI_TRANSFORM_SZ,        
    };

    public enum HAPI_RSTOrder          
    {
        HAPI_TRS = 0,        
        HAPI_TSR,        
        HAPI_RTS,        
        HAPI_RST,        
        HAPI_STR,        
        HAPI_SRT,        
        HAPI_RSTORDER_DEFAULT = HAPI_SRT,        
    };

    public enum HAPI_XYZOrder          
    {
        HAPI_XYZ = 0,        
        HAPI_XZY,        
        HAPI_YXZ,        
        HAPI_YZX,        
        HAPI_ZXY,        
        HAPI_ZYX,        
        HAPI_XYZORDER_DEFAULT = HAPI_XYZ,        
    };

    public enum HAPI_ImageDataFormat          
    {
        HAPI_IMAGE_DATA_UNKNOWN = -1,        
        HAPI_IMAGE_DATA_INT8,        
        HAPI_IMAGE_DATA_INT16,        
        HAPI_IMAGE_DATA_INT32,        
        HAPI_IMAGE_DATA_FLOAT16,        
        HAPI_IMAGE_DATA_FLOAT32,        
        HAPI_IMAGE_DATA_MAX,        
        HAPI_IMAGE_DATA_DEFAULT = HAPI_IMAGE_DATA_INT8,        
    };

    public enum HAPI_ImagePacking          
    {
        HAPI_IMAGE_PACKING_UNKNOWN = -1,        
        HAPI_IMAGE_PACKING_SINGLE,        //Single Channel
        HAPI_IMAGE_PACKING_DUAL,        //Dual Channel
        HAPI_IMAGE_PACKING_RGB,        //RGB
        HAPI_IMAGE_PACKING_BGR,        //RGB Reversed
        HAPI_IMAGE_PACKING_RGBA,        //RGBA
        HAPI_IMAGE_PACKING_ABGR,        //RGBA Reversed
        HAPI_IMAGE_PACKING_MAX,        
        HAPI_IMAGE_PACKING_DEFAULT3 = HAPI_IMAGE_PACKING_RGB,        
        HAPI_IMAGE_PACKING_DEFAULT4 = HAPI_IMAGE_PACKING_RGBA,        
    };

    public enum HAPI_EnvIntType          //Used with HAPI_GetEnvInt to retrieve basic informationabout the HAPI implementation currently being linkedagainst. Note that as of HAPI version 2.0 these enum values areguaranteed never to change so you can reliably get this information fromany post-2.0 version of HAPI. The same goes for the actualHAPI_GetEnvInt API call.
    {
        HAPI_ENVINT_INVALID = -1,        
        HAPI_ENVINT_VERSION_HOUDINI_MAJOR = 100,        //The three components of the Houdini version that HAPI isexpecting to link against.@{
        HAPI_ENVINT_VERSION_HOUDINI_MINOR = 110,        
        HAPI_ENVINT_VERSION_HOUDINI_BUILD = 120,        
        HAPI_ENVINT_VERSION_HOUDINI_PATCH = 130,        
        HAPI_ENVINT_VERSION_HOUDINI_ENGINE_MAJOR = 200,        //The two components of the Houdini Engine marketed version.@{
        HAPI_ENVINT_VERSION_HOUDINI_ENGINE_MINOR = 210,        
        HAPI_ENVINT_VERSION_HOUDINI_ENGINE_API = 220,        //This is a monotonously increasing API version number that can be usedto lock against a certain API for compatibility purposes. Basicallywhen this number changes code compiled against the HAPI.h methodsmight no longer compile. Semantic changes to the methods will alsocause this version to increase. This number will be reset to 0every time the Houdini Engine version is bumped.
        HAPI_ENVINT_MAX,        
    };

    public enum HAPI_SessionEnvIntType          //This enum is to be used with HAPI_GetSessionEnvInt to retrieve basicsession-specific information.
    {
        HAPI_SESSIONENVINT_INVALID = -1,        
        HAPI_SESSIONENVINT_LICENSE = 100,        //License Type. See HAPI_License.
        HAPI_SESSIONENVINT_MAX,        
    };

    public enum HAPI_CacheProperty          //Identifies a memory cache
    {
        HAPI_CACHEPROP_CURRENT,        //Current memory usage in MB. Setting this to 0 invokesa cache clear.
        HAPI_CACHEPROP_HAS_MIN,        //True if it actually has a minimum size.
        HAPI_CACHEPROP_MIN,        //Min cache memory limit in MB.
        HAPI_CACHEPROP_HAS_MAX,        //True if it actually has a maximum size.
        HAPI_CACHEPROP_MAX,        //Max cache memory limit in MB.
        HAPI_CACHEPROP_CULL_LEVEL,        //How aggressive to cull memory. This only works for:- HAPI_CACHE_COP_COOK where:0 -> Never reduce inactive cache.1 -> Always reduce inactive cache.- HAPI_CACHE_OBJ where:0 -> Never enforce the max memory limit.1 -> Always enforce the max memory limit.- HAPI_CACHE_SOP where:0 -> When to Unload = NeverWhen to Limit Max Memory = Never1-2 -> When to Unload = Based on FlagWhen to Limit Max Memory = Never3-4 -> When to Unload = Based on FlagWhen to Limit Max Memory = Always5 -> When to Unload = AlwaysWhen to Limit Max Memory = Always
    };

    public enum HAPI_HeightFieldSampling          //Type of sampling for heightfield
    {
        HAPI_HEIGHTFIELD_SAMPLING_CENTER,        
        HAPI_HEIGHTFIELD_SAMPLING_CORNER,        
    };

    public enum HAPI_PDG_State          //Used with PDG functions
    {
        HAPI_PDG_STATE_READY,        
        HAPI_PDG_STATE_COOKING,        
        HAPI_PDG_STATE_MAX,        
        HAPI_PDG_STATE_MAX_READY_STATE = HAPI_PDG_STATE_READY,        
    };

    public enum HAPI_PDG_EventType          //Used with PDG functions
    {
        HAPI_PDG_EVENT_NULL,        //An empty undefined event. Should be ignored.
        HAPI_PDG_EVENT_WORKITEM_ADD,        //Sent when a new work item is added by a node
        HAPI_PDG_EVENT_WORKITEM_REMOVE,        //Sent when a work item is deleted from a node
        HAPI_PDG_EVENT_WORKITEM_STATE_CHANGE,        //Sent when a work item state changes
        HAPI_PDG_EVENT_WORKITEM_ADD_DEP,        //Sent when a work item has a dependency added
        HAPI_PDG_EVENT_WORKITEM_REMOVE_DEP,        //Sent when a dependency is removed from a work item
        HAPI_PDG_EVENT_WORKITEM_ADD_PARENT,        //Sent from dynamic work items that generate from a cooked item
        HAPI_PDG_EVENT_WORKITEM_REMOVE_PARENT,        //Sent when the parent item for a work item is deleted
        HAPI_PDG_EVENT_NODE_CLEAR,        //A node event that indicates that node is about to have all its work items cleared
        HAPI_PDG_EVENT_COOK_ERROR,        //Sent when an error is issued by the node
        HAPI_PDG_EVENT_COOK_WARNING,        //Sent when an warning is issued by the node
        HAPI_PDG_EVENT_COOK_COMPLETE,        //Sent for each node in the graph when a cook completes
        HAPI_PDG_EVENT_DIRTY_START,        //A node event indicating that one more items in the node will be dirtied
        HAPI_PDG_EVENT_DIRTY_STOP,        //A node event indicating that the node has finished dirtying items
        HAPI_PDG_EVENT_DIRTY_ALL,        //A event indicating that the entire graph is about to be dirtied
        HAPI_PDG_EVENT_UI_SELECT,        //A work item event that indicates the item has been selected in the TOPs UI
        HAPI_PDG_EVENT_NODE_CREATE,        //Sent when a new node is created
        HAPI_PDG_EVENT_NODE_REMOVE,        //Sent when a node was removed from the graph
        HAPI_PDG_EVENT_NODE_RENAME,        //Sent when a node was renamed
        HAPI_PDG_EVENT_NODE_CONNECT,        //Sent when a node was connected to another node
        HAPI_PDG_EVENT_NODE_DISCONNECT,        //Sent when a node is disconnected from another node
        HAPI_PDG_EVENT_WORKITEM_SET_INT,        //Deprecated
        HAPI_PDG_EVENT_WORKITEM_SET_FLOAT,        //Deprecated
        HAPI_PDG_EVENT_WORKITEM_SET_STRING,        //Deprecated
        HAPI_PDG_EVENT_WORKITEM_SET_FILE,        //Deprecated
        HAPI_PDG_EVENT_WORKITEM_SET_PYOBJECT,        //Deprecated
        HAPI_PDG_EVENT_WORKITEM_SET_GEOMETRY,        //Deprecated
        HAPI_PDG_EVENT_WORKITEM_MERGE,        //Deprecated
        HAPI_PDG_EVENT_WORKITEM_RESULT,        //Sent when an output file is added to a work item
        HAPI_PDG_EVENT_WORKITEM_PRIORITY,        //Deprecated
        HAPI_PDG_EVENT_COOK_START,        //Sent for each node in the graph when a cook starts
        HAPI_PDG_EVENT_WORKITEM_ADD_STATIC_ANCESTOR,        //Deprecated
        HAPI_PDG_EVENT_WORKITEM_REMOVE_STATIC_ANCESTOR,        //Deprecated
        HAPI_PDG_EVENT_NODE_PROGRESS_UPDATE,        //Deprecated
        HAPI_PDG_EVENT_BATCH_ITEM_INITIALIZED,        //Deprecated
        HAPI_PDG_EVENT_ALL,        //A special enum that represents the OR of all event types
        HAPI_PDG_EVENT_LOG,        //A special enum that represents the OR of both the `CookError` and `CookWarning` events
        HAPI_PDG_EVENT_SCHEDULER_ADDED,        //Sent when a new scheduler is added to the graph
        HAPI_PDG_EVENT_SCHEDULER_REMOVED,        //Sent when a scheduler is removed from the graph
        HAPI_PDG_EVENT_SET_SCHEDULER,        //Deprecated
        HAPI_PDG_EVENT_SERVICE_MANAGER_ALL,        //Deprecated
        HAPI_PDG_EVENT_NODE_COOKED,        //Sent when a node finishes cooking
        HAPI_PDG_EVENT_NODE_GENERATED,        //Sent when a node finished generating
        HAPI_PDG_CONTEXT_EVENTS,        
    };

    public enum HAPI_PDG_WorkitemState          //Used with PDG functions
    {
        HAPI_PDG_WORKITEM_UNDEFINED,        
        HAPI_PDG_WORKITEM_UNCOOKED,        
        HAPI_PDG_WORKITEM_WAITING,        
        HAPI_PDG_WORKITEM_SCHEDULED,        
        HAPI_PDG_WORKITEM_COOKING,        
        HAPI_PDG_WORKITEM_COOKED_SUCCESS,        
        HAPI_PDG_WORKITEM_COOKED_CACHE,        
        HAPI_PDG_WORKITEM_COOKED_FAIL,        
        HAPI_PDG_WORKITEM_COOKED_CANCEL,        
        HAPI_PDG_WORKITEM_DIRTY,        
    };


}
