#!/usr/local/bin/fish

set -l PROJECT_PATH "SubscriptionSplitter.Infrastructure"
set -l STARTUP_PROJECT_PATH "SubscriptionSplitter.WebApi"


dotnet ef $argv --project $PROJECT_PATH --startup-project $STARTUP_PROJECT_PATH