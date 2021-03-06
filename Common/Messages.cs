/*
 * LambdaSharp (λ#)
 * Copyright (C) 2018-2020
 * lambdasharp.net
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace Demo.WebSocketsChat.Common {

    public abstract class AMessageRequest {

        //--- Properties ---
        public string Action { get; set; }
    }

    public class SendMessageRequest : AMessageRequest {

        //--- Properties ---
        public string Text { get; set; }
    }

    public class RenameUserRequest : AMessageRequest {

        //--- Properties ---
        public string UserName { get; set; }
    }

    public class NotifyResponse {

        //--- Properties ---
        public string Action { get; set; }
    }

    public class UserMessageResponse : NotifyResponse {

        //--- Constructors ---
        public UserMessageResponse() => Action = "message";

        //--- Properties ---
        public string From { get; set; }
        public string Text { get; set; }
    }

    public class UserNameResponse : NotifyResponse  {

        //--- Constructors ---
        public UserNameResponse() => Action = "username";

        //--- Properties ---
        public string UserName { get; set; }
    }

    public class NotifyMessage {

        //--- Properties ---
        public string Message { get; set; }
        public string ConnectionId { get; set; }
    }
}
