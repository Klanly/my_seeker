//code generated by generator don't edit.
using Google.Protobuf;

namespace EngineCore
{
	public static class MessageParser
	{
		public static IMessage Parse(int msgid, byte[] inputData)
        {
            IMessage res; 
            switch (msgid)
            {
               case MessageDefine.ExceptionResponse:
                res = ExceptionResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.ExceptionRemoteLoginResponse:
                res = ExceptionRemoteLoginResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.GmAddAttr:
                res = GmAddAttr.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.GmAddProp:
                res = GmAddProp.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.GmFinishTask:
                res = GmFinishTask.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.GmOfficer:
                res = GmOfficer.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.GMGetPlayerMessageRequest:
                res = GMGetPlayerMessageRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.GMGetPlayerMessageResponse:
                res = GMGetPlayerMessageResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSEnterRequest:
                res = CSEnterRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCEnterResponse:
                res = SCEnterResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSQuitRequest:
                res = CSQuitRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCQuitResponse:
                res = SCQuitResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSSuspendRequest:
                res = CSSuspendRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCSuspendResponse:
                res = SCSuspendResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSResumeRequest:
                res = CSResumeRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCResumeResponse:
                res = SCResumeResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSStartRequest:
                res = CSStartRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCStartResponse:
                res = SCStartResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSFinishRequest:
                res = CSFinishRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCFinishResponse:
                res = SCFinishResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSRegRequest:
                res = CSRegRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCRegResponse:
                res = SCRegResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSAuthRequest:
                res = CSAuthRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCAuthResponse:
                res = SCAuthResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSloginRequest:
                res = CSloginRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCloginResponse:
                res = SCloginResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSChapterListRequest:
                res = CSChapterListRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCChapterListResponse:
                res = SCChapterListResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSChapterDetailRequest:
                res = CSChapterDetailRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCChapterDetailResponse:
                res = SCChapterDetailResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCClueUnlockNotice:
                res = SCClueUnlockNotice.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCNpcUnLockNotice:
                res = SCNpcUnLockNotice.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCSceneUnLockNotice:
                res = SCSceneUnLockNotice.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCChapterTaskStatusChangeNotice:
                res = SCChapterTaskStatusChangeNotice.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCChapterStatusChangeNotice:
                res = SCChapterStatusChangeNotice.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCChapterRedNotice:
                res = SCChapterRedNotice.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSClearChapterRedRequest:
                res = CSClearChapterRedRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSSceneEnterRequest:
                res = CSSceneEnterRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCSceneEnterResponse:
                res = SCSceneEnterResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSSceneRewardRequest:
                res = CSSceneRewardRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCSceneRewardResponse:
                res = SCSceneRewardResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSSceneQuitRequest:
                res = CSSceneQuitRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCSceneQuitResponse:
                res = SCSceneQuitResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSSceneSuspendRequest:
                res = CSSceneSuspendRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCSceneSuspendResponse:
                res = SCSceneSuspendResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSSceneResumeRequest:
                res = CSSceneResumeRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCSceneResumeResponse:
                res = SCSceneResumeResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSSceneStartRequest:
                res = CSSceneStartRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCSceneStartResponse:
                res = SCSceneStartResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSSearchSceneSelectOfficerReq:
                res = CSSearchSceneSelectOfficerReq.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCSearchSceneSelectOfficerResp:
                res = SCSearchSceneSelectOfficerResp.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSBuyItemRequest:
                res = CSBuyItemRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCBuyItemResponse:
                res = SCBuyItemResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSPlayerPropRequest:
                res = CSPlayerPropRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCPlayerPropResponse:
                res = SCPlayerPropResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSPlayerPropRecentRequest:
                res = CSPlayerPropRecentRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCPlayerPropRecentResposne:
                res = SCPlayerPropRecentResposne.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSPlayerInfoRequest:
                res = CSPlayerInfoRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCPlayerInfoResponse:
                res = SCPlayerInfoResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSRenameRequest:
                res = CSRenameRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCRenameResponse:
                res = SCRenameResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSOfficerListRequest:
                res = CSOfficerListRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCOfficerListResponse:
                res = SCOfficerListResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSOfficerInfoRequest:
                res = CSOfficerInfoRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCOfficerInfoResponse:
                res = SCOfficerInfoResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSEventPhaseFeedbackRequest:
                res = CSEventPhaseFeedbackRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCEventPhaseFeedbackResponse:
                res = SCEventPhaseFeedbackResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSEventRewardRequest:
                res = CSEventRewardRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCEventRewardResponse:
                res = SCEventRewardResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSOfficerCombineRequest:
                res = CSOfficerCombineRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCOfficerCombineResponse:
                res = SCOfficerCombineResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSOfficerUpdateRequest:
                res = CSOfficerUpdateRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCOfficerUpdateResponse:
                res = SCOfficerUpdateResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSEventEnterRequest:
                res = CSEventEnterRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCEventEnterResponse:
                res = SCEventEnterResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSEventDropInfoRequest:
                res = CSEventDropInfoRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCEventDropInfoResponse:
                res = SCEventDropInfoResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSSkillEmitRequest:
                res = CSSkillEmitRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCSkillEmitResponse:
                res = SCSkillEmitResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSSkillTimerEmitReq:
                res = CSSkillTimerEmitReq.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCSkillTimerEmitResp:
                res = SCSkillTimerEmitResp.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSReasoningRewardReq:
                res = CSReasoningRewardReq.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSFindEnterReq:
                res = CSFindEnterReq.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCFindEnterResp:
                res = SCFindEnterResp.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSFindRewardReq:
                res = CSFindRewardReq.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCFindRewardResp:
                res = SCFindRewardResp.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSSkyEyeRewardReq:
                res = CSSkyEyeRewardReq.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCSkyEyeRewardReq:
                res = SCSkyEyeRewardReq.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSSkyEyeReq:
                res = CSSkyEyeReq.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCSkyEyeReq:
                res = SCSkyEyeReq.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.MarketRequest:
                res = MarketRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.MarketResponse:
                res = MarketResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.MarkeBuyRequest:
                res = MarkeBuyRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.MarkeBuyResponse:
                res = MarkeBuyResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSMarketItemRequest:
                res = CSMarketItemRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCMarketItemResponse:
                res = SCMarketItemResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.MarkeFreshRequest:
                res = MarkeFreshRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.MarkeFreshResponse:
                res = MarkeFreshResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSNoticeListRequest:
                res = CSNoticeListRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCNoticeListResponse:
                res = SCNoticeListResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSPingRequest:
                res = CSPingRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCPingResponse:
                res = SCPingResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSMessageRequest:
                res = CSMessageRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.LottoRequest:
                res = LottoRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.LottoResponse:
                res = LottoResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.LottoBuyRequest:
                res = LottoBuyRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.LottoBuyResponse:
                res = LottoBuyResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSGooglePayChargeRequest:
                res = CSGooglePayChargeRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCGooglePayChargeResponse:
                res = SCGooglePayChargeResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSIOSPayChargeRequest:
                res = CSIOSPayChargeRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCIOSPayChargeResponse:
                res = SCIOSPayChargeResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCAcceptTaskNotice:
                res = SCAcceptTaskNotice.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSTaskListRequest:
                res = CSTaskListRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCTaskListResponse:
                res = SCTaskListResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSTaskCommitRequest:
                res = CSTaskCommitRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCTaskCommitResponse:
                res = SCTaskCommitResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCTaskStatusChangeNotice:
                res = SCTaskStatusChangeNotice.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSTriggerTaskActiveRequest:
                res = CSTriggerTaskActiveRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCTriggerTaskActiveResponse:
                res = SCTriggerTaskActiveResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSTaskIdListRequest:
                res = CSTaskIdListRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCTaskIdListResponse:
                res = SCTaskIdListResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSAchievementRequest:
                res = CSAchievementRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCAchievementResponse:
                res = SCAchievementResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSAchievementSubmitRequest:
                res = CSAchievementSubmitRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCAchievementSubmitResponse:
                res = SCAchievementSubmitResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSActivityBaseListRequest:
                res = CSActivityBaseListRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCActivityBaseListResponse:
                res = SCActivityBaseListResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSActivityRequest:
                res = CSActivityRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCActivityDropResponse:
                res = SCActivityDropResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSActivityRewardRequest:
                res = CSActivityRewardRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCActivityRewardResponse:
                res = SCActivityRewardResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSCartoonEnterRequest:
                res = CSCartoonEnterRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCCartoonEnterResponse:
                res = SCCartoonEnterResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSCartoonRewardRequest:
                res = CSCartoonRewardRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCCartoonRewardReqsponse:
                res = SCCartoonRewardReqsponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSCartoonQuitRequest:
                res = CSCartoonQuitRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSEmailListRequest:
                res = CSEmailListRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCEmailListResponse:
                res = SCEmailListResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSEmailRewardRequest:
                res = CSEmailRewardRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCEmailRewardResponse:
                res = SCEmailRewardResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSEmailReadRequest:
                res = CSEmailReadRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCEmailChangeNotice:
                res = SCEmailChangeNotice.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSTitleRequest:
                res = CSTitleRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCTitleResponse:
                res = SCTitleResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSTitleActiveRequest:
                res = CSTitleActiveRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCTitleActiveResponse:
                res = SCTitleActiveResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSTitleGetRequest:
                res = CSTitleGetRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCTitleGetResponse:
                res = SCTitleGetResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSFriendRequest:
                res = CSFriendRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCFriendResponse:
                res = SCFriendResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSFriendAddRequest:
                res = CSFriendAddRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCFriendAddResponse:
                res = SCFriendAddResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSFriendDelRequest:
                res = CSFriendDelRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCFriendDelResponse:
                res = SCFriendDelResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSFriendAgreeRequest:
                res = CSFriendAgreeRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCFriendAgreeResponse:
                res = SCFriendAgreeResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSFriendDelApplyRequest:
                res = CSFriendDelApplyRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCFriendDelApplyResponse:
                res = SCFriendDelApplyResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSFriendGiftRequest:
                res = CSFriendGiftRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCFriendGiftResponse:
                res = SCFriendGiftResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSFriendGiftSendRequest:
                res = CSFriendGiftSendRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCFriendGiftSendResponse:
                res = SCFriendGiftSendResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSFriendGiftDrawRequest:
                res = CSFriendGiftDrawRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCFriendGiftDrawResponse:
                res = SCFriendGiftDrawResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSFriendViewRequest:
                res = CSFriendViewRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCFriendViewResponse:
                res = SCFriendViewResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSFriendSwitchRequest:
                res = CSFriendSwitchRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCFriendSwitchResponse:
                res = SCFriendSwitchResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCFriendApplyResponse:
                res = SCFriendApplyResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCFriendNoticeResponse:
                res = SCFriendNoticeResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSFriendRecommendListRequest:
                res = CSFriendRecommendListRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCFriendRecommendListResponse:
                res = SCFriendRecommendListResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSFriendRecommendGetRequest:
                res = CSFriendRecommendGetRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCFriendRecommendGetResponse:
                res = SCFriendRecommendGetResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSFriendRecommendApplyRequest:
                res = CSFriendRecommendApplyRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCFriendRecommendApplyResponse:
                res = SCFriendRecommendApplyResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSBuildingListReq:
                res = CSBuildingListReq.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCBuildingListResp:
                res = SCBuildingListResp.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSBuildingUnlockReq:
                res = CSBuildingUnlockReq.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCBuildingUnlockResp:
                res = SCBuildingUnlockResp.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSCanTaskRequest:
                res = CSCanTaskRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCCanTaskResponse:
                res = SCCanTaskResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCreceiveNewTitle:
                res = SCreceiveNewTitle.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSRegGuestRequest:
                res = CSRegGuestRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCRegGuestResponse:
                res = SCRegGuestResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSIdentifyCheckRequest:
                res = CSIdentifyCheckRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCIdentifyCheckRepsonse:
                res = SCIdentifyCheckRepsonse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSFBLoginRequest:
                res = CSFBLoginRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCFBLoginResponse:
                res = SCFBLoginResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSFBBindRequest:
                res = CSFBBindRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCFBBindResponse:
                res = SCFBBindResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCIdentifyCheckMuiltyMessage:
                res = SCIdentifyCheckMuiltyMessage.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.PlayerPropSellRequest:
                res = PlayerPropSellRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.PlayerPropSellResposne:
                res = PlayerPropSellResposne.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSDropReq:
                res = CSDropReq.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCDropResp:
                res = SCDropResp.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCAutoOpenGiftDropResp:
                res = SCAutoOpenGiftDropResp.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSChatFinishRequest:
                res = CSChatFinishRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCChatFinishResponse:
                res = SCChatFinishResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSGetAllRewardedTasksRequest:
                res = CSGetAllRewardedTasksRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCGetAllRewardedTasksResponse:
                res = SCGetAllRewardedTasksResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSPlayerCheckInInfoReq:
                res = CSPlayerCheckInInfoReq.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCPlayerCheckInInfoResp:
                res = SCPlayerCheckInInfoResp.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSPlayerCheckInReq:
                res = CSPlayerCheckInReq.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCPlayerCheckInResp:
                res = SCPlayerCheckInResp.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSPlayerRenewIconReq:
                res = CSPlayerRenewIconReq.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCPlayerRenewIconResp:
                res = SCPlayerRenewIconResp.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCPlayerUpLevel:
                res = SCPlayerUpLevel.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSPlayerGuildRequest:
                res = CSPlayerGuildRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCPlayerGuildResponse:
                res = SCPlayerGuildResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSPlayerGuildUpdateRequest:
                res = CSPlayerGuildUpdateRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSPlayerFeedbackRequest:
                res = CSPlayerFeedbackRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCPlayerFeedbackResponse:
                res = SCPlayerFeedbackResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCAchievementUnlockResponse:
                res = SCAchievementUnlockResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCActivityNewResponse:
                res = SCActivityNewResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSSceneReconnectRequest:
                res = CSSceneReconnectRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCSceneReconnectResponse:
                res = SCSceneReconnectResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSSceneDifficultyReq:
                res = CSSceneDifficultyReq.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCSceneDifficultyResp:
                res = SCSceneDifficultyResp.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSJigsawReconnectRequest:
                res = CSJigsawReconnectRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCJigsawReconnectResponse:
                res = SCJigsawReconnectResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSGetServiceConfigRequest:
                res = CSGetServiceConfigRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCGetServiceConfigResponse:
                res = SCGetServiceConfigResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSGetServiceConfigSingleRequest:
                res = CSGetServiceConfigSingleRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCGetServiceConfigSingleResponse:
                res = SCGetServiceConfigSingleResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSGetPathConfigRequest:
                res = CSGetPathConfigRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCGetPathConfigResponse:
                res = SCGetPathConfigResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSClientLogRequest:
                res = CSClientLogRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSGetPushRequest:
                res = CSGetPushRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCGetPushResponse:
                res = SCGetPushResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSBuyPushRequest:
                res = CSBuyPushRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCBuyPushResponse:
                res = SCBuyPushResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSCombineInfoRequest:
                res = CSCombineInfoRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCCombineInfoResponse:
                res = SCCombineInfoResponse.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.CSCombineRequest:
                res = CSCombineRequest.Parser.ParseFrom(inputData);
                break;
               case MessageDefine.SCCombineResponse:
                res = SCCombineResponse.Parser.ParseFrom(inputData);
                break;
		
                default:
                    return null;
            }
            return res;
        }
	}
}