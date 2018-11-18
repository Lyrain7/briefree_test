using UnityEngine;
using System.Collections;

public delegate void VOID_FUN_VOID ();

public enum UiState	{ BringIn_Animaiton , BringInEnd , DissMissAnimation , DissMissEnd }
public enum RecruitSong { Null , Level , Genre , Stat , Cost }
public enum TRAINING_KEY { Sing , Dance , Visual , Passion , Expert , Sense }
public enum Particle_Color { Red , Pink , Orange , Green , Blue }
public enum Particle_Live { b_Pink , b_Blue , b_Green , p_Pink, p_Blue , p_Green , Album }

public enum SelectBringIn { Null, Schedule , Commu , Director , Song , album , operate }
//public enum TRAINING_KEY { Sing , Dance , Exper , Social , Perfo , Visual }

public enum InfoTag { Team , Personal , Ranking }

public class Constant : MonoBehaviour {

	public const int MEMBER_CNT = 5;
	public const int TEAM_CNT 	= 3;

	public const int 	TC_TITLE 	= -1,
						TC_NAME 	= 0,
						TC_MEMBER 	= 1,
						TC_ABIL 	= 2,
						TC_USER 	= 3,
						TC_GAME 	= 4;

	public const string MSG_TEXT_YUNA 		= "TEXT_YUNA",
						MSG_TEXT_MINHA 		= "TEXT_MINHA",
						MSG_TEXT_LISA 		= "TEXT_LISA",
						MSG_TEXT_TAMI 		= "TEXT_TAMI",
						MSG_TEXT_GAYOUNG 	= "TEXT_GAYOUNG";


	public const string MSG_TIP_BASE = "TIP_";

	public const string LOADING_MSG 		= "LOADING_MSG",
						LOADING_MSG_PER 	= "LOADING_MSG_PER";

	public const int 	CHARACTER_NUMBER_YUNA 		= 0,
						CHARACTER_NUMBER_MINHA 		= 1,
						CHARACTER_NUMBER_TAMI 		= 2,
						CHARACTER_NUMBER_LISA 		= 3,
						CHARACTER_NUMBER_GAYOUNG 	= 4;

    public const string CHARACTER_NAME_KOR_YUNA     = "유나",
                        CHARACTER_NAME_KOR_MINHA    = "민하",
                        CHARACTER_NAME_KOR_TAMI     = "타미",
                        CHARACTER_NAME_KOR_LISA     = "리사",
                        CHARACTER_NAME_KOR_GAYOUNG  = "가영";

	public const int 	CHARACTER_POS_CENTER = 0,
						CHARACTER_POS_LINE_1 = 1,
						CHARACTER_POS_LINE_2 = 2;

	public const string CHARACTER_TITLE_IMAGE_YUNA 		= "IMG_Char_Card_Yuna",
						CHARACTER_TITLE_IMAGE_MINHA 	= "IMG_Char_Card_Minha",
						CHARACTER_TITLE_IMAGE_TAMI 		= "IMG_Char_Card_Tami",
						CHARACTER_TITLE_IMAGE_LISA 		= "IMG_Char_Card_Lisa",
						CHARACTER_TITLE_IMAGE_GAYOUNG 	= "IMG_Char_Card_Gayoung";

	public const string CHARACTER_NAME_IMAGE_YUNA 		= "Img_UI_Charname_Yuna01",
						CHARACTER_NAME_IMAGE_MINHA 		= "Img_UI_Charname_Minha01",
						CHARACTER_NAME_IMAGE_TAMI 		= "Img_UI_Charname_Tami01",
						CHARACTER_NAME_IMAGE_LISA 		= "Img_UI_Charname_Lisa01",
						CHARACTER_NAME_IMAGE_GAYOUNG 	= "Img_UI_Charname_Gayoung01";

	public const string CHARACTER_PORTRAIT_YUNA 	= "Img_Char_Portrait_Yuna01",
						CHARACTER_PORTRAIT_MINHA 	= "Img_Char_Portrait_Minha01",
						CHARACTER_PORTRAIT_TAMI 	= "Img_Char_Portrait_Tami01",
						CHARACTER_PORTRAIT_LISA 	= "Img_Char_Portrait_Lisa01",
						CHARACTER_PORTRAIT_GAYOUNG 	= "Img_Char_Portrait_Gayoung01";

	public const string CHARACTER_PORTRAIT_TEAM_YUNA 	= "Img_Char_Portrait_Yuna01",
						CHARACTER_PORTRAIT_TEAM_MINHA 	= "Img_Char_Portrait_Minha01",
						CHARACTER_PORTRAIT_TEAM_TAMI 	= "Img_Char_Portrait_Tami01",
						CHARACTER_PORTRAIT_TEAM_LISA 	= "Img_Char_Portrait_Lisa01",
						CHARACTER_PORTRAIT_TEAM_GAYOUNG = "Img_Char_Portrait_Gayoung01";

    public const string CHARACTER_PORTRAIT_SKILL_YUNA     = "Img_Char_Portrait_Yuna02",
                        CHARACTER_PORTRAIT_SKILL_MINHA    = "Img_Char_Portrait_Minha02",
                        CHARACTER_PORTRAIT_SKILL_TAMI     = "Img_Char_Portrait_Tami02",
                        CHARACTER_PORTRAIT_SKILL_LISA     = "Img_Char_Portrait_Lisa02",
                        CHARACTER_PORTRAIT_SKILL_GAYOUNG  = "Img_Char_Portrait_Gayoung02";

	public const string CHARACTER_PROFILE_YUNA 		= "IMG_Char_Profile_Yuna",
						CHARACTER_PROFILE_MINHA 	= "IMG_Char_Profile_Minha",
						CHARACTER_PROFILE_TAMI 		= "IMG_Char_Profile_Tami",
						CHARACTER_PROFILE_LISA 		= "IMG_Char_Profile_Lisa",
						CHARACTER_PROFILE_GAYOUNG 	= "IMG_Char_Profile_Gayoung";

	public const string CHARACTER_ROUNDING_YUNA 	= "Img_Char_YunaRounding",
						CHARACTER_ROUNDING_MINHA 	= "Img_Char_MinhaRounding",
						CHARACTER_ROUNDING_TAMI 	= "Img_Char_TamiRounding",
						CHARACTER_ROUNDING_LISA 	= "Img_Char_LisaRounding",
						CHARACTER_ROUNDING_GAYOUNG 	= "Img_Char_GayoungRounding";

    public const string CHARACTER_COMMU_YUNA    = "UI_Card_CH_Yuna",
                        CHARACTER_COMMU_MINHA   = "UI_Card_CH_Minha",
                        CHARACTER_COMMU_TAMI    = "UI_Card_CH_Tami",
                        CHARACTER_COMMU_LISA    = "UI_Card_CH_Lisa",
                        CHARACTER_COMMU_GAYOUNG = "UI_Card_CH_Gayoung";

	public const string CHARACTER_PORTRAIT_EMPTY 	= "IMG_UI_BasicTone";

	public const string MAIN_ROOM_NAME = "Msh_MainRoom_01",
						MAIN_ROOM_NAME_1 = "Msh_MainRoom_02";

	public const string MSG_NEW_GAME_SET 			= "NEW_GAME_SET",
						MSG_UNIT_MEMBER 			= "UNIT_MEMBER",
						MSG_PRODUCER_PROFILE 		= "PRODUCER_PROFILE",
						MSG_NAME 					= "NAME",
						MSG_CAREER 					= "CAREER",
						MSG_SEX 					= "SEX",
						MSG_BIRTH_DAY 				= "BIRTH_DAY",
						MSG_PRODUCER_TEXT 			= "PRODUCER_TEXT",
						MSG_NEW_NAME 				= "NEW_NAME",
						MSG_MEMBER_PROFILE 			= "MEMBER_PROFILE",
						MSG_MEMBER_TEXT 			= "MEMBER_TEXT",
						MSG_BODY 					= "BODY",
						MSG_SIZE 					= "SIZE",
						MSG_BLOOD 					= "BLOOD",
						MSG_SPECIALITY 				= "SPECIALITY",
						MSG_MEMBER_TEXT_OTHER 		= "MEMBER_TEXT_OTHER",
						MSG_PRODUCER_TEXT_OTHER 	= "PRODUCER_TEXT_OTHER",
						MSG_SING					= "MSG_SING", 
						MSG_DANCE					= "MSG_DANCE",
						MSG_VISUAL					= "MSG_VISUAL",
						MSG_PASSION					= "MSG_PASSION",
						MSG_EXPERT					= "MSG_EXPERT",
						MSG_SENSE					= "MSG_SENSE",
						MSG_desc_training_0			= "MSG_desc_training_0",
						MSG_desc_training_1			= "MSG_desc_training_1",
						MSG_desc_training_2			= "MSG_desc_training_2",
						MSG_desc_training_3			= "MSG_desc_training_3",
						MSG_desc_training_4			= "MSG_desc_training_4",
						MSG_desc_training_5			= "MSG_desc_training_5",
						MSG_SELECT 					= "MSG_SELECT",
						MSG_SCHEDULE_TITLE 			= "MSG_SCHEDULE_TITLE",
						MSG_SCHEDULE_TITLE_TEXT 	= "MSG_SCHEDULE_TITLE_TEXT",
						MSG_SCHEDULE_COST 			= "MSG_SCHEDULE_COST",
						MSG_SCHEDULE_EFFECT 		= "MSG_SCHEDULE_EFFECT",
						MSG_SCHEDULE_FAIL 			= "MSG_SCHEDULE_FAIL",
						MSG_STEMINA 				= "MSG_STEMINA",
						MSG_EMOTION 				= "MSG_EMOTION",
						MSG_TECHNIQUE 				= "MSG_TECHNIQUE",
						MSG_MENTAL 					= "MSG_MENTAL",
						MSG_TRAINING_TITLE 			= "MSG_TRAINING_TITLE",
						MSG_TRAINING_TITLE_TEXT 	= "MSG_TRAINING_TITLE_TEXT",
						MSG_TRAINING_RETUN_POINT 	= "MSG_TRAINING_RETUN_POINT",
						MSG_TRAINING_TEAM_STATUS 	= "MSG_TRAINING_TEAM_STATUS",
						MSG_OK 						= "MSG_OK",
						MSG_INVEST 					= "MSG_INVEST",
						MSG_INVEST_TITLE_TEXT 		= "MSG_INVEST_TITLE_TEXT",
						MSG_INVEST_TAP_TOTAL 		= "MSG_INVEST_TAP_TOTAL",
						MSG_INVEST_TAP_FAC 			= "MSG_INVEST_TAP_FAC",
						MSG_INVEST_TAP_STAF 		= "MSG_INVEST_TAP_STAF",
						MSG_INVEST_TAP_MAR 			= "MSG_INVEST_TAP_MAR",
						MSG_INVEST_TAP_MAN 			= "MSG_INVEST_TAP_MAN",
						MSG_PROGRESS 				= "MSG_PROGRESS",
						MSG_SCHEDULE_TOTAL_RESULT 	= "MSG_SCHEDULE_TOTAL_RESULT",
						MSG_RANK 					= "MSG_RANK",
						MSG_MONEY 					= "MSG_MONEY",
						MSG_CASH 					= "MSG_CASH",
						MSG_HOME 					= "MSG_HOME",
						MSG_SCHEDULE 				= "MSG_SCHEDULE",
						MSG_COMU 					= "MSG_COMU",
						MSG_TRAIN 					= "MSG_TRAIN",
						MSG_STATUS 					= "MSG_STATUS",
						MSG_CENTER 					= "MSG_CENTER",
						MSG_CANCEL 					= "MSG_CANCEL",
						MSG_WARNING 				= "MSG_WARNING",
						MSG_QUIT 					= "MSG_QUIT",
						MSG_QUIT_TEXT 				= "MSG_QUIT_TEXT",
						MSG_TEAM_STATUS_TEXT 		= "MSG_TEAM_STATUS_TEXT",
						MSG_WILL 					= "MSG_WILL",
						MSG_CHK_MEMBER 				= "MSG_CHK_MEMBER",
						MSG_CHK_P_NAME 				= "MSG_CHK_P_NAME",
						MSG_BIRTH_FORM 				= "MSG_BIRTH_FORM",
						MSG_TEAM_CREATE 			= "MSG_TEAM_CREATE",
						MSG_PLAY_SCHEDULE 			= "MSG_PLAY_SCHEDULE",
						MSG_TRAINING_RETURN 		= "MSG_TRAINING_RETURN",
						MSG_CHK_MONEY 				= "MSG_CHK_MONEY",
						MSG_RETURN_TITLE 			= "MSG_RETURN_TITLE",
						MSG_CHK_CONDITION 			= "MSG_CHK_CONDITION",
						MSG_SCHEDULE_SUCCESS 		= "MSG_SCHEDULE_SUCCESS",
						MSG_POINT_TAG				= "MSG_POINT_TAG",

						// 공고 msg.
						MSG_RECRUIT_LEVEL			= "MSG_RECRUIT_LEVEL",
						MSG_RECRUIT_LEVEL_TEXT		= "MSG_RECRUIT_LEVEL_TEXT",
						MSG_RECRUIT_LEVEL_L_1		= "MSG_RECRUIT_LEVEL_L_1",
						MSG_RECRUIT_LEVEL_L_2		= "MSG_RECRUIT_LEVEL_L_2",
						MSG_RECRUIT_LEVEL_L_3		= "MSG_RECRUIT_LEVEL_L_3",
						MSG_RECRUIT_LEVEL_L_4		= "MSG_RECRUIT_LEVEL_L_4",
						MSG_RECRUIT_LEVEL_L_5		= "MSG_RECRUIT_LEVEL_L_5",
						MSG_RECRUIT_L_TEXT_1		= "MSG_RECRUIT_L_TEXT_1",
						MSG_RECRUIT_L_TEXT_2		= "MSG_RECRUIT_L_TEXT_2",
						MSG_RECRUIT_L_TEXT_3		= "MSG_RECRUIT_L_TEXT_3",
						MSG_RECRUIT_L_TEXT_4		= "MSG_RECRUIT_L_TEXT_4",
						MSG_RECRUIT_L_TEXT_5		= "MSG_RECRUIT_L_TEXT_5",

						MSG_RECRUIT_GENRE 			= "MSG_RECRUIT_GENRE",
						MSG_RECRUIT_GENRE_TEXT 		= "MSG_RECRUIT_GENRE_TEXT",

						MSG_RECRUIT_STAT 			= "MSG_RECRUIT_STAT",
						MSG_RECRUIT_STAT_TEXT		= "MSG_RECRUIT_STAT_TEXT",
						MSG_RECRUIT_STAT_L_1		= "MSG_RECRUIT_STAT_L_1",
						MSG_RECRUIT_STAT_L_2		= "MSG_RECRUIT_STAT_L_2",
						MSG_RECRUIT_STAT_L_3		= "MSG_RECRUIT_STAT_L_3",
						MSG_RECRUIT_STAT_L_4		= "MSG_RECRUIT_STAT_L_4",
						MSG_RECRUIT_STAT_L_5		= "MSG_RECRUIT_STAT_L_5",
						MSG_RECRUIT_S_TEXT_1		= "MSG_RECRUIT_S_TEXT_1",
						MSG_RECRUIT_S_TEXT_2		= "MSG_RECRUIT_S_TEXT_2",
						MSG_RECRUIT_S_TEXT_3		= "MSG_RECRUIT_S_TEXT_3",
						MSG_RECRUIT_S_TEXT_4		= "MSG_RECRUIT_S_TEXT_4",
						MSG_RECRUIT_S_TEXT_5		= "MSG_RECRUIT_S_TEXT_5",

						MSG_RECRUIT_PROMO			= "MSG_RECRUIT_PROMO",
						MSG_RECRUIT_PROMO_TEXT		= "MSG_RECRUIT_PROMO_TEXT",
						MSG_RECRUIT_PROMO_L_1		= "MSG_RECRUIT_PROMO_L_1",
						MSG_RECRUIT_PROMO_L_2		= "MSG_RECRUIT_PROMO_L_2",
						MSG_RECRUIT_PROMO_L_3		= "MSG_RECRUIT_PROMO_L_3",
						MSG_RECRUIT_PROMO_L_4		= "MSG_RECRUIT_PROMO_L_4",
						MSG_RECRUIT_PROMO_L_5		= "MSG_RECRUIT_PROMO_L_5",
						MSG_RECRUIT_P_TEXT_1		= "MSG_RECRUIT_P_TEXT_1",
						MSG_RECRUIT_P_TEXT_2		= "MSG_RECRUIT_P_TEXT_2",
						MSG_RECRUIT_P_TEXT_3		= "MSG_RECRUIT_P_TEXT_3",
						MSG_RECRUIT_P_TEXT_4		= "MSG_RECRUIT_P_TEXT_4",
						MSG_RECRUIT_P_TEXT_5		= "MSG_RECRUIT_P_TEXT_5",

						MSG_BACK 					= "BACK",
						MSG_NEXT 					= "NEXT",
						MSG_PRODUCTION_NAME 		= "PRODUCTION_NAME",
						MSG_PRODUCTION_NAME_SET 	= "PRODUCTION_NAME_SET",
						MSG_PRODUCTION_TEXT_1 		= "PRODUCTION_TEXT_1",
						MSG_PRODUCTION_TEXT_2 		= "PRODUCTION_TEXT_2",
						MSG_INPUT 					= "INPUT",
						MSG_NO 						= "NO",
						MSG_TEAM_MEMBER_SET 		= "TEAM_MEMBER_SET",
						MSG_COMMENT 				= "COMMENT",
						MSG_MEMBER_INFO 			= "MEMBER_INFO",
						MSG_SELECT_ABILITY 			= "SELECT_ABILITY",
						MSG_ABILITY_SELECT 			= "ABILITY_SELECT",
						MSG_SELECTED_ABILITY 		= "SELECTED_ABILITY",
						MSG_ABILITY_NULL 			= "ABILITY_NULL",
						MSG_ABILITY_HAVE 			= "ABILITY_HAVE",
						MSG_USER_INFO 				= "USER_INFO",
						CORPORATION					= "CORPORATION",
						PRODUCTION					= "PRODUCTION",
						ENTERTAINMENT				= "ENTERTAINMENT",
						MUSIC						= "MUSIC",
						WORD						= "WORD",
                        DECIDE                      = "DECIDE",
                        REMOVE                      = "REMOVE";







	public const int training_max = 100;


	public const string INVEST_MSG_BASE 	= "INVEST_",
						INVEST_DESC_BASE 	= "INVEST_MSG_";

    public const string OPERATE_MSG_BASE = "OPERATE_";

	public const string BTN_PRESS 	= "IMG_UI_NameButtonPressed",
						BTN_NORMAL 	= "IMG_UI_NameButton";

	public const string NULL = "null",
						NONE = "none";


	public const string STAMINA 	= "STAMINA",
						EMOTION 	= "EMOTION",
						TECHNIQUE 	= "TECHNIQUE",
						MENTAL 		= "MENTAL",
						PROMOTE 	= "PROMOTE",
						INCOME 		= "INCOME",
						REST 		= "REST",
						OFFER 		= "OFFER";

	public const string SCHEDULE_BASE 	= "SCHEDULE_",
						TRAINING_BASE 	= "traning_",
						INVEST_BASE 	= "invest_",
                        OPERATE_BASE    = "operate_";

    public const string OPERATE_UTAGE_EVENT = "OPEREVENT_";

	public const string DOCS_PROFILE_BASE = "char_";

	public const string SCHDULE_BASE_DOCS = "schedule_";
	public const string SCHEDULE_DESC_BASE = "SCHEDULE_DESC_";

    public const string UTAGE_ATT_BASE = "ATTR_";

   

	public const string SINGLE_DOCS_BASE = "single_";
	public const string ITEM_DOCS_BASE = "item_";
	public const string CLOTHES_DOCS_BASE = "clothes_";
    public const string HAIRS_DOCS_BASE = "hair_";
    public const string COMMU_DOCS_BASE = "commu_";
    public const string STATUS_DOCS_BASE = "status_";

    public const string GEM_DOCS_BASE = "gem_";
    public const string GROUP_BASE = "group_";

	public const string CATEGORY_SINGLE_ALBUM = "single_album";
	public const string CATEGORY_ITEM = "item";
	public const string CATEGORY_CLOTHES = "clothes";
    public const string CATEGORY_HAIRS = "hairs";

	public const string SPRITE_MALE 	= "Img_UI_Button_Male",
						SPRITE_FEMALE 	= "Img_UI_Button_Female";

	public const string MALE 			= "MALE",
						FEMALE 			= "FEMALE",
						IDOL_CAREER 	= "IMG_UI_IDOLcareer",
						COMPOSE_CAREER 	= "IMG_UI_Composecareer",
						MBA_CAREER 		= "IMG_UI_MBAcareer",
						NONE_CAREER 	= "IMG_UI_NoneCareer";

	public const int 	CAREER_CODE_IDOL 	= 0,
						CAREER_CODE_COMPOSE = 1,
						CAREER_CODE_MBA 	= 2,
						CAREER_CODE_NONE 	= 3;

	public const int 	CHARACTER_HP_BASE 	= 100,
						CHARACTER_HP_MAX 	= 100,
						CHARACTER_WILL_BASE = 50,
						CHARACTER_WILL_MAX 	= 100;

	public const int TEAM_STATUS_CNT = 6;

	public const float 	SCHEDULE_RESULT_LV1 = 40,
						SCHEDULE_RESULT_LV2 = 60,
						SCHEDULE_RESULT_LV3 = 80;

	public const float 	SCHEDULE_FAIL_LV1 = 1.0f,
						SCHEDULE_FAIL_LV2 = 0.5f,
						SCHEDULE_FAIL_LV3 = 0.2f;

	public const float SCHEDULE_FAIL_MAX = 1.0f;

	public const float SCHEDULE_PLAT_TIME = 5.0f;

	public const int 	TEAMSTAT_STAMINA 		= 0,
						TEAMSTAT_MENTAL 	 	= 1,
						TEAMSTAT_TECHNIQUE 	 	= 2,
						TEAMSTAT_EMOTION 	 	= 3,
						TEAMSTAT_PROMOTE 		= 4,
						TEAMSTAT_MONEY 			= 5,
						TEAMSTAT_CONDITION 		= 6,
						TEAMSTAT_WILL 			= 7;

	public const string SRPTIE_ARROW_UP 	= "Img_UI_ArrowUp01",
						SRPTIE_ARROW_DOWN 	= "Img_UI_ArrowDown01";

	public const string UTAGE_TEAM_NAME 		= "회사명",
						UTAGE_USER_NAME 		= "유저네임",
						UTAGE_MONEY 			= "자금",
						UTAGE_POP 				= "인기도",
						UTAGE_RANK 				= "팀레벨",
						UTAGE_REPUTE 			= "호감도",
						UTAGE_TOPIC 			= "화제성",

						UTAGE_CENTER_NAME 		= "센터이름",
						UTAGE_CENTER_HP 		= "센터컨디션",
						UTAGE_CENTER_WILL 		= "센터의욕",
						UTAGE_CENTER_LV 		= "센터레벨",

                        UTAGE_CENTER_GOOD   = "센터호감도",
                        UTAGE_CENTER_CLOSE  = "센터친밀도",
                        UTAGE_CENTER_MANAGE = "센터관리",

						UTAGE_2ND_NAME 			= "2nd이름",
						UTAGE_2ND_HP 			= "2nd컨디션",
						UTAGE_2ND_WILL 			= "2nd의욕",
						UTAGE_2ND_LV 			= "2nd레벨",

                        UTAGE_2ND_GOOD      = "2nd호감도",
                        UTAGE_2ND_CLOSE     = "2nd친밀도",
                        UTAGE_2ND_MANAGE    = "2nd관리",

						UTAGE_3RD_NAME 			= "3rd이름",
						UTAGE_3RD_HP 			= "3rd컨디션",
						UTAGE_3RD_WILL 			= "3rd의욕",
						UTAGE_3RD_LV 			= "3rd레벨",

                        UTAGE_3RD_GOOD      = "3rd호감도",
                        UTAGE_3RD_CLOSE     = "3rd친밀도",
                        UTAGE_3RD_MANAGE    = "3rd관리",

						UTAGE_SELECT_YUNA 		= "유나선택",
						UTAGE_SELECT_MINHA 		= "민하선택",
						UTAGE_SELECT_TAMI		= "타미선택",
						UTAGE_SELECT_LISA 		= "리사선택",
						UTAGE_SELECT_GAYOUNG 	= "가영선택",

						UTAGE_PLAY_YEAR 		= "게임연차",
                        UTAGE_PLAY_MONTH        = "게임월",
                        UTAGE_PLAY_DAY          = "게임일",
                        UTAGE_PLAY_TOTALDAY     = "누적일수",

						UTAGE_INTRO_END			= "인트로확인",						

						UTAGE_SCHEDULE = "현재스케쥴";

    public const string UTAGE_WILL_BASE = "의욕",
                        UTAGE_CONDITION_BASE = "컨디션";



    public const string UTAGE_YUNA_GOOD     = "유나호감도",
                        UTAGE_YUNA_CLOSE    = "유나친밀도",
                        UTAGE_LISA_GOOD     = "리사호감도",
                        UTAGE_LISA_CLOSE    = "리사친밀도",
                        UTAGE_MINHA_GOOD    = "민하호감도",
                        UTAGE_MINHA_CLOSE   = "민하친밀도",
                        UTAGE_TAMI_GOOD     = "타미호감도",
                        UTAGE_TAMI_CLOSE    = "타미친밀도",
                        UTAGE_GAYOUNG_GOOD  = "가영호감도",
                        UTAGE_GAYOUNG_CLOSE = "가영친밀도",
                        UTAGE_MIJIN_GOOD    = "미진호감도",
                        UTAGE_MIJIN_CLOSE   = "미진친밀도",
                        UTAGE_TAEHYUN_GOOD  = "태현호감도",
                        UTAGE_TAEHYUN_CLOSE = "태현친밀도",
                        UTAGE_WONJUN_GOOD   = "원준호감도",
                        UTAGE_WONJUN_CLOSE  = "원준친밀도",
                        UTAGE_SANGHUN_GOOD  = "상훈호감도",
                        UTAGE_SANGHUN_CLOSE = "상훈친밀도",
                        UTAGE_JIWON_GOOD    = "지원호감도",
                        UTAGE_JIWON_CLOSE   = "지원친밀도",
                        UTAGE_SEHYUN_GOOD   = "세연호감도",
                        UTAGE_SEHYUN_CLOSE  = "세연친밀도",
                        UTAGE_HYUNJI_GOOD   = "현지호감도",
                        UTAGE_HYUNJI_CLOSE  = "현지친밀도",
                        UTAGE_CHERRY_GOOD   = "체리호감도",
                        UTAGE_CHERRY_CLOSE  = "체리친밀도",
                        UTAGE_AYOUNG_GOOD   = "아영호감도",
                        UTAGE_AYOUNG_CLOSE  = "아영친밀도",
                        UTAGE_DG_GOOD       = "DG호감도",
                        UTAGE_DG_CLOSE      = "DG친밀도",
                        UTAGE_SUNA_GOOD     = "선아호감도",
                        UTAGE_SUNA_CLOSE    = "선아친밀도",
                        UTAGE_CAIL_GOOD     = "카일호감도",
						UTAGE_CAIL_CLOSE    = "카일친밀도";

	public const string	UTAGE_TEAM_STAT0 = "가창력",
						UTAGE_TEAM_STAT1 = "댄스",
						UTAGE_TEAM_STAT2 = "비주얼",
						UTAGE_TEAM_STAT3 = "열정",
						UTAGE_TEAM_STAT4 = "노련함",
						UTAGE_TEAM_STAT5 = "센스";

    public const string UTAGE_TEAM_EXP      = "인기도",
                        UTAGE_TEAM_TOPIC    = "화제성",
                        UTAGE_TEAM_FAVOR    = "호감도";


	public const string UTAGE_RECRUIT_SONG 	= "공고중",
						UTAGE_ALBUM_MAKE 	= "앨범제작중";

    public const string UTAGE_YUNA_WILL         = "유나의욕",
                        UTAGE_YUNA_CONDITION    = "유나컨디션",
                        UTAGE_YUNA_MANAGE       = "유나관리",
                        UTAGE_MINHA_WILL        = "민하의욕",
                        UTAGE_MINHA_CONDITION   = "민하컨디션",
                        UTAGE_MINHA_MANAGE      = "민하관리",
                        UTAGE_TAMI_WILL         = "타미의욕",
                        UTAGE_TAMI_CONDITION    = "타미컨디션",
                        UTAGE_TAMI_MANAGE       = "타미관리",
                        UTAGE_LISA_WILL         = "리사의욕",
                        UTAGE_LISA_CONDITION    = "리사컨디션",
                        UTAGE_LISA_MANAGE       = "리사관리",
                        UTAGE_GAYOUNG_WILL      = "가영의욕",
                        UTAGE_GAYOUNG_CONDITION = "가영컨디션",
                        UTAGE_GAYOUNG_MANAGE    = "가영관리";

    public const string UTAGE_YUNA_DESC     = "유나관심사",
                        UTAGE_MINHA_DESC    = "민하관심사",
                        UTAGE_TAMI_DESC     = "타미관심사",
                        UTAGE_LISA_DESC     = "리사관심사",
                        UTAGE_GAYOUNG_DESC  = "가영관심사";

	public const string YUNA_SONG			= "유나 가창력",
						YUNA_DANCE			= "유나 댄스",
						YUNA_VISUAL			= "유나 비주얼",
						YUNA_PASSION		= "유나 열정",
						YUNA_EXPERT			= "유나 노련함",
						YUNA_SENCE			= "유나 센스",
						MINHA_SONG			= "민하 가창력",
						MINHA_DANCE			= "민하 댄스",
						MINHA_VISUAL		= "민하 비주얼",
						MINHA_PASSION		= "민하 열정",
						MINHA_EXPERT		= "민하 노련함",
						MINHA_SENCE			= "민하 센스",
						TAMI_SONG			= "타미 가창력",
						TAMI_DANCE			= "타미 댄스",
						TAMI_VISUAL			= "타미 비주얼",
						TAMI_PASSION		= "타미 열정",
						TAMI_EXPERT			= "타미 노련함",
						TAMI_SENCE			= "타미 센스",
						LISA_SONG			= "리사 가창력",
						LISA_DANCE			= "리사 댄스",
						LISA_VISUAL			= "리사 비주얼",
						LISA_PASSION		= "리사 열정",
						LISA_EXPERT			= "리사 노련함",
						LISA_SENCE			= "리사 센스",
						GAYOUNG_SONG		= "가영 가창력",
						GAYOUNG_DANCE		= "가영 댄스",
						GAYOUNG_VISUAL		= "가영 비주얼",
						GAYOUNG_PASSION		= "가영 열정",
						GAYOUNG_EXPERT		= "가영 노련함",
						GAYOUNG_SENCE		= "가영 센스",
						GEM_GET_SPD			= "잼 획득 속도",
						GEM_GET_PT			= "잼 획득 포인트",
						GEM_CRT_SPD			= "잼 생성 속도",
						TAEHYUN_SKILL_UP	= "태현 스킬 강화",
						MIJIN_SKILL_UP		= "미진 스킬 강화",
						WONJUN_SKILL_UP		= "원준 스킬 강화",
						SANGHUN_SKILL_UP	= "상훈 스킬 강화",
						CHACH_MAX			= "지도 포인트 최대치",
						CHACH_REC			= "지도 포인트 회복속도",
						LIVE_POP			= "라이브 인기도",
						LIVE_MONEY			= "라이브 돈",
						LIVE_SKILL			= "라이브 스킬",
						SCH_SPD 			= "일반스케쥴 진행 속도",
						COMMU_COOL 			= "방문 쿨타임",
						SCH_ODD 			= "외부스케쥴 확률";

	public const string commu_Yuna 		= "commu_Yuna",
						commu_Tami		= "commu_Tami",
						commu_Minha		= "commu_Minha",
						commu_Lisa		= "commu_Lisa",
						commu_Gayoung	= "commu_Gayoung",
						commu_CEO		= "commu_CEO",
						commu_Manager	= "commu_Mijin",
						commu_Taehyun 	= "commu_Taehyun";

	public const string SCHEDULE_EVENT_KEY = "Start_Sch";

	public const string IMAGE_FONT_CHAIRMAN = "IMG_UI_Charname_ChairMan",
						IMAGE_FONT_MANAGER  = "IMG_UI_Charname_Manager";

	public const string HOME_INFO_KEY = "home_";

	public const string SHORTCUT_YUNA = "Img_Char_Portrait_Yuna00_",
						SHORTCUT_MINHA = "Img_Char_Portrait_Minha00_",
						SHORTCUT_TAMI = "Img_Char_Portrait_Tami00_",
						SHORTCUT_LISA = "Img_Char_Portrait_Lisa00_",
						SHORTCUT_GAYOUNG = "Img_Char_Portrait_Gayoung00_";


	public const string COLOR_PAD_YUNA 		= "IMG_UI_YunaColorPad",
						COLOR_PAD_MINHA 	= "IMG_UI_MinhaColorPad",
						COLOR_PAD_TAMI 		= "IMG_UI_TamiColorPad",
						COLOR_PAD_LISA 		= "IMG_UI_LisaColorPad",
						COLOR_PAD_GAYOUNG 	= "IMG_UI_GayoungColorPad",
						COLOR_PAD_MANAGER 	= "IMG_UI_ManagerColorPad",
						COLOR_PAD_CHAIRMAN 	= "IMG_UI_ChairManColorPad";

	public const string INVEST_CATEGORY_DIET 		= "FoodStyle",
						INVEST_CATEGORY_LIVING 		= "PermissionRest",
						INVEST_CATEGORY_MARKETING 	= "MaketingCost",
						INVEST_CATEGORY_SCHEDULE 	= "ScheduleAttitude",
						INVEST_CATEGORY_TREINING 	= "TrainingStyle";

	public const int 	INVEST_CATEGORY_DIET_IDX 		= 0,
						INVEST_CATEGORY_LIVING_IDX 		= 1,
						INVEST_CATEGORY_MARKETING_IDX 	= 3,
						INVEST_CATEGORY_SCHEDULE_IDX 	= 2,
						INVEST_CATEGORY_TREINING_IDX 	= 4;

    public const string INVEST_MARKETING = "Marketing";

	public const string INVEST_TYPE_CHK 	= "chk",
						INVEST_TYPE_OVERLAP = "overlap",
						INVEST_TYPE_LEVEL 	= "level";

    public const int INVEST_LEVEL_COST = 200;

	public const string DOCS_TEAM_TITLE_BASE = "team_";

	public const int ALBUM_MAKE_MAX_WEEK = 5;

	public const string ALBUM_CRITICS_BASE = "ALBUM_CRITICS_";

	public const int ALBUM_LEVEL_MAX = 8;

	public const string CON_NAME_0 = "Img_UI_Emo_Angry",
						CON_NAME_1 = "Img_UI_Emo_Bad",
						CON_NAME_2 = "Img_UI_Emo_Normal",
						CON_NAME_3 = "Img_UI_Emo_Good",
						CON_NAME_4 = "Img_UI_Emo_Happy";


	// 앨범 항목 단계별 float 값.
	public const float 	ALBUM_LEVEL_0 = 0.0f,
						ALBUM_LEVEL_1 = 1.0f,
						ALBUM_LEVEL_2 = 2.0f,
						ALBUM_LEVEL_3 = 2.5f,
						ALBUM_LEVEL_4 = 3.0f,
						ALBUM_LEVEL_5 = 3.5f,
						ALBUM_LEVEL_6 = 4.0f,
						ALBUM_LEVEL_7 = 4.5f,
						ALBUM_LEVEL_8 = 5.0f;

	// 단계별 idx.
	public const int 	ALBUM_LEVEL_INT_0 = 0,
						ALBUM_LEVEL_INT_1 = 1,
						ALBUM_LEVEL_INT_2 = 2,
						ALBUM_LEVEL_INT_3 = 3,
						ALBUM_LEVEL_INT_4 = 4,
						ALBUM_LEVEL_INT_5 = 5,
						ALBUM_LEVEL_INT_6 = 6,
						ALBUM_LEVEL_INT_7 = 7;


	public const float ALBUM_LEVEL_QUL_MAX = 3;


	public const string DOCSPIN_LIVE_BASE 		= "live_";

	public const string DOCSPIN_LIVE_NAME 		= "stage",
						DOCSPIN_LIVE_BG 		= "bg",
						DOCSPIN_LIVE_ANIM 		= "animation",
						DOCSPIN_LIVE_ANIM_CAM 	= "Cam_Anim";

	public const string DOCSPIN_DIRECTOR_BASE = "director_";
	public const string DOCSPIN_ATTRIBUTE_BASE = "att_";
	public const string DOCSPIN_ALBUM_SCHEDULE = "sc_card_";
    public const string DOCSPIN_LIVE_INFO_BASE = "live_info_";
    public const string DOCSPIN_CHAR_ANIM = "char_live_";
    public const string DOCSPIN_CAMERA_ANIM = "stage_live_";

    public const string ALBUM_BASE = "album";


	public const int ATTRIBUTE_MAX_SIZE = 4;

	public const int 	WILL_LEVEL_1 = 20,
						WILL_LEVEL_2 = 40,
						WILL_LEVEL_3 = 60,
						WILL_LEVEL_4 = 70,
						WILL_LEVEL_5 = 100;

	public const string SCH_TRAINING = "SCH_TRAINING";

	public const string ALBUM_SC_STAT_0 = "완성도",
						ALBUM_SC_STAT_1 = "음악성",
						ALBUM_SC_STAT_2 = "컨셉트",
						ALBUM_SC_STAT_3 = "퍼포먼스",
						ALBUM_SC_STAT_4 = "전염성";

    public const string ALBUM_SC_STAT_ICON_0 = "IMG_UI_Greatness",
                        ALBUM_SC_STAT_ICON_1 = "IMG_UI_Musicality",
                        ALBUM_SC_STAT_ICON_2 = "IMG_UI_Concept",
                        ALBUM_SC_STAT_ICON_3 = "IMG_UI_Perfomance",
                        ALBUM_SC_STAT_ICON_4 = "IMG_UI_Marketing";

	public const string LIVE_SONG 		= "노래",
						LIVE_STAGE 		= "무대",
						LIVE_REACTION 	= "반응";

	public const string LIVE_SPRITE_SONG 		= "IMG_UI_Musicality2",
						LIVE_SPRITE_STAGE 		= "IMG_UI_Perfomance2",
						LIVE_SPRITE_REACTION 	= "IMG_UI_Marketing2";

	public const string LIVE_SPRITE_EMO_ANGRY 	= "Img_UI_Emo_Angry",
						LIVE_SPRITE_EMO_BAD 	= "Img_UI_Emo_Bad",
						LIVE_SPRITE_EMO_NORMAL 	= "Img_UI_Emo_Normal",
						LIVE_SPRITE_EMO_GOOD 	= "Img_UI_Emo_Good",
						LIVE_SPRITE_EMO_HAPPY 	= "Img_UI_Emo_Happy";

	public const float MENU_WAIT_TIME = 0.6f;

	public const int 	STAT_GRADE_S 	= 208,
						STAT_GRADE_AP 	= 186,
						STAT_GRADE_A 	= 165,
						STAT_GRADE_AM 	= 145,
						STAT_GRADE_BP 	= 126,
						STAT_GRADE_B 	= 108,
						STAT_GRADE_BM 	= 91,
						STAT_GRADE_CP 	= 75,
						STAT_GRADE_C 	= 60,
						STAT_GRADE_CM 	= 46,
						STAT_GRADE_DP 	= 33,
						STAT_GRADE_D 	= 21,
						STAT_GRADE_DM 	= 10,
						STAT_GRADE_F 	= 0;

    public const string LIVE_SETTING_CLOTH_YUNA     = "ICON_EQUIP_Yuna_Cloth_",
                        LIVE_SETTING_CLOTH_MINHA    = "ICON_EQUIP_Minha_Cloth_",
                        LIVE_SETTING_CLOTH_TAMI     = "ICON_EQUIP_Tami_Cloth_",
                        LIVE_SETTING_CLOTH_LISA     = "ICON_EQUIP_Lisa_Cloth_",
                        LIVE_SETTING_CLOTH_GAYOUNG  = "ICON_EQUIP_Gayoung_Cloth_";

    public const string LIVE_SETTING_HAIR_YUNA      = "ICON_EQUIP_Yuna_Hair_",
                        LIVE_SETTING_HAIR_MINHA     = "ICON_EQUIP_Minha_Hair_",
                        LIVE_SETTING_HAIR_TAMI      = "ICON_EQUIP_Tami_Hair_",
                        LIVE_SETTING_HAIR_LISA      = "ICON_EQUIP_Lisa_Hair_",
                        LIVE_SETTING_HAIR_GAYOUNG   = "ICON_EQUIP_Gayoung_Hair_";

    public const float TRAINING_GAUGE_MAX_TIME = 4.0f;

    public const string BTN_ABLE                = "Button_Run_02",
                        BTN_UNABLE              = "Button_R_Unable",
                        BTN_CONFIRM             = "Button_R_ConFirm",
                        BTN_PREV_ABLE           = "Button_R100",
                        BTN_PREV_UNABLE         = "Button_R100_gray",
                        BTN_PREV_ABLE_ICON      = "Icon_Back",
                        BTN_PREV_UNABLE_ICON    = "Icon_Back_gray";

    public const string ATT_SPRITE_ABLE     = "AbilBox_150px",
                        ATT_SPRITE_UNABLE   = "AbilBox_150px_gray";

    public const string BTN_COLOR_PINK = "UI_Button_Pink",
                        BTN_COLOR_BLUE = "UI_Button_Blue";

    public const string CATEGORY_COMMU_MEMBER       = "Member",
                        CATEGORY_COMMU_PLACE        = "Place",
                        CATEGORY_COMMU_CHARACTER    = "Character";

    public const string CATEGORY_LIVE = "Live";

    public const string CATEGORY_UI_DRESS       = "Dress",
                        CATEGORY_UI_ITEM        = "Item",
                        CATEGORY_UI_MUSIC       = "Music",
                        CATEGORY_UI_OFFICIAL    = "Official",
                        CATEGORY_UI_PRODUCER    = "Producer",
                        CATEGORY_UI_SONG        = "Song",
                        CATEGORY_UI_TRAINING    = "Training",
                        CATEGORY_UI_UNOFFICIAL  = "Unofficial";

    public const string CATEGORY_UI_IMG_CHARACTER   = "UI_Card_Boarder_Character",
                        CATEGORY_UI_IMG_DRESS       = "UI_Card_Boarder_Dress",
                        CATEGORY_UI_IMG_ITEM        = "UI_Card_Boarder_Item",
                        CATEGORY_UI_IMG_MEMBER      = "UI_Card_Boarder_Member",
                        CATEGORY_UI_IMG_MUSIC       = "UI_Card_Boarder_Music",
                        CATEGORY_UI_IMG_OFFICIAL    = "UI_Card_Boarder_Official",
                        CATEGORY_UI_IMG_PLACE       = "UI_Card_Boarder_Place",
                        CATEGORY_UI_IMG_PRODUCER    = "UI_Card_Boarder_Producer",
                        CATEGORY_UI_IMG_SONG        = "UI_Card_Boarder_Song",
                        CATEGORY_UI_IMG_TRAINING    = "UI_Card_Boarder_Training",
                        CATEGORY_UI_IMG_UNOFFCIAL   = "UI_Card_Boarder_Unofficial";

    public const string CATEGORY_UI_IMG_LIVE = "UI_Card_Boarder_Live";

    public const string STATUS_TYPE_TEAM    = "team",
                        STATUS_TYPE_MEMBER  = "member",
                        STATUS_TYPE_USER    = "user";

    public const string COMMU_SHOP = "UI_Shop";

    #region utage event

    public const string EVENT_VALUE_UTAGE   = "EVENTVALUE_",
                        EVENT_FLAG_UTAGE    = "EVENTFLAG_";

    public const int    EVENT_VALUE_CNT = 20,
                        EVENT_FALG_CNT  = 20;

    #endregion




    #region schedule icon

    public const string SCHEDULE_NAME_STA       = "체력",
                        SCHEDULE_ICON_STA       = "UI_Icon_Stamina",
						SCHEDULE_NAME_MENTAL    = "멘탈",
						SCHEDULE_ICON_MENTAL    = "UI_Icon_Mental",
                        SCHEDULE_NAME_TECH      = "기교",
						SCHEDULE_ICON_TECH      = "UI_Icon_Technic",
						SCHEDULE_NAME_EMO       = "감성",
						SCHEDULE_ICON_EMO       = "UI_Icon_Emotion",
                        
                        SCHEDULE_NAME_POP       = "인기도",
                        SCHEDULE_ICON_POP       = "UI_Icon_Popular",
                        SCHEDULE_NAME_COND      = "컨디션",
                        SCHEDULE_ICON_COND      = "UI_Icon_Condition",

                        SCHEDULE_NAME_ISSUE     = "화제성",
                        SCHEDULE_ICON_ISSUE     = "UI_Icon_Issue",
                        SCHEDULE_NAME_LIKE      = "호감도",
                        SCHEDULE_ICON_LIKE      = "UI_Icon_Like",
                        SCHEDULE_NAME_WILL      = "의욕",
                        SCHEDULE_ICON_WILL      = "UI_Icon_Will",
						SCHEDULE_ICON_MONEY     = "UI_ICON_Money";

    #endregion

    public const string INVEST_LEVEL_SPRITE_1 = "UI_IMG_5Slider_gauge1-5",
                        INVEST_LEVEL_SPRITE_2 = "UI_IMG_5Slider_gauge2-5",
                        INVEST_LEVEL_SPRITE_3 = "UI_IMG_5Slider_gauge3-5",
                        INVEST_LEVEL_SPRITE_4 = "UI_IMG_5Slider_gauge4-5",
                        INVEST_LEVEL_SPRITE_5 = "UI_IMG_5Slider_gauge5-5";


    public const string IMG_GEM_STEMINA = "Gem_Stamina",
                        IMG_GEM_TECHNIC = "Gem_Technic",
                        IMG_GEM_MENTAL  = "Gem_Mental",
                        IMG_GEM_EMO     = "Gem_Emo",
                        IMG_GEM_COACH   = "Gem_Coach",
                        IMG_GEM_ISSUE   = "Gem_Issue",
                        IMG_GEM_LIKE    = "Gem_Like",
                        IMG_GEM_MONEY   = "Gem_Money";

    public const float  gem_x_min = -3f,
                        gem_x_max = 1f,
                        gem_y_min = -1f,
                        gem_y_max = 0.85f;

    public const int SCHEDULE_SELECT_CODE = -1000;

    public const string TITLE_CHAR_IMG          = "MainTitle_Character",
                        TITLE_CHAR_IMG_WHITE    = "MainTitle_Character_white";

    public const string BASE_BOX = "BasicBox_R0";



}
