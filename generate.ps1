$ErrorActionPreference = "Stop"

$projectRoot = (Get-Item $PSScriptRoot).FullName
$protos_base_dir = 'protos'
$target_dir = Join-Path $projectRoot (Join-Path 'src' 'generated')
Write-Host $target_dir

$files = (
'data-plane-api/envoy/annotations/deprecation.proto',
'data-plane-api/envoy/annotations/resource.proto',
'data-plane-api/envoy/config/accesslog/v3/accesslog.proto',
'data-plane-api/envoy/config/cluster/v3/circuit_breaker.proto',
'data-plane-api/envoy/config/cluster/v3/cluster.proto',
'data-plane-api/envoy/config/cluster/v3/filter.proto',
'data-plane-api/envoy/config/cluster/v3/outlier_detection.proto',
'data-plane-api/envoy/config/core/v3/address.proto',
'data-plane-api/envoy/config/core/v3/backoff.proto',
'data-plane-api/envoy/config/core/v3/base.proto',
'data-plane-api/envoy/config/core/v3/config_source.proto',
'data-plane-api/envoy/config/core/v3/event_service_config.proto',
'data-plane-api/envoy/config/core/v3/extension.proto',
'data-plane-api/envoy/config/core/v3/grpc_service.proto',
'data-plane-api/envoy/config/core/v3/health_check.proto',
'data-plane-api/envoy/config/core/v3/http_uri.proto',
'data-plane-api/envoy/config/core/v3/protocol.proto',
'data-plane-api/envoy/config/core/v3/proxy_protocol.proto',
'data-plane-api/envoy/config/core/v3/resolver.proto',
'data-plane-api/envoy/config/core/v3/socket_option.proto',
'data-plane-api/envoy/config/core/v3/substitution_format_string.proto',
'data-plane-api/envoy/config/endpoint/v3/endpoint.proto',
'data-plane-api/envoy/config/endpoint/v3/endpoint_components.proto',
'data-plane-api/envoy/config/route/v3/route_components.proto',
'data-plane-api/envoy/config/route/v3/route.proto',
'data-plane-api/envoy/config/route/v3/scoped_route.proto',
'data-plane-api/envoy/config/trace/v3/http_tracer.proto',
'data-plane-api/envoy/data/accesslog/v3/accesslog.proto',
'data-plane-api/envoy/extensions/common/ratelimit/v3/ratelimit.proto',
'data-plane-api/envoy/extensions/filters/network/http_connection_manager/v3/http_connection_manager.proto',
'data-plane-api/envoy/extensions/transport_sockets/tls/v3/common.proto',
'data-plane-api/envoy/extensions/transport_sockets/tls/v3/secret.proto',
'data-plane-api/envoy/extensions/transport_sockets/tls/v3/tls.proto',
'data-plane-api/envoy/extensions/upstreams/http/v3/http_protocol_options.proto',
'data-plane-api/envoy/service/auth/v3/*.proto',
'data-plane-api/envoy/service/cluster/v3/cds.proto',
'data-plane-api/envoy/service/discovery/v3/discovery.proto',
'data-plane-api/envoy/service/ratelimit/v3/rls.proto',
'data-plane-api/envoy/service/secret/v3/sds.proto',
'data-plane-api/envoy/type/http/v3/path_transformation.proto',
'data-plane-api/envoy/type/matcher/v3/metadata.proto',
'data-plane-api/envoy/type/matcher/v3/number.proto',
'data-plane-api/envoy/type/matcher/v3/regex.proto',
'data-plane-api/envoy/type/matcher/v3/string.proto',
'data-plane-api/envoy/type/matcher/v3/value.proto',
'data-plane-api/envoy/type/metadata/v3/metadata.proto',
'data-plane-api/envoy/type/tracing/v3/custom_tag.proto',
'data-plane-api/envoy/type/v3/http.proto',
'data-plane-api/envoy/type/v3/http_status.proto',
'data-plane-api/envoy/type/v3/percent.proto',
'data-plane-api/envoy/type/v3/range.proto',
'data-plane-api/envoy/type/v3/ratelimit_unit.proto',
'data-plane-api/envoy/type/v3/semantic_version.proto',
'data-plane-api/envoy/type/v3/token_bucket.proto',
'protoc-gen-validate/validate/validate.proto',
'xds/udpa/annotations/migrate.proto',
'xds/udpa/annotations/security.proto',
'xds/udpa/annotations/sensitive.proto',
'xds/udpa/annotations/status.proto',
'xds/udpa/annotations/versioning.proto',
'xds/xds/annotations/v3/status.proto',
'xds/xds/core/v3/authority.proto',
'xds/xds/core/v3/collection_entry.proto',
'xds/xds/core/v3/context_params.proto',
'xds/xds/core/v3/extension.proto',
'xds/xds/core/v3/resource_locator.proto',
'xds/xds/type/matcher/v3/matcher.proto',
'xds/xds/type/matcher/v3/regex.proto',
'xds/xds/type/matcher/v3/string.proto',
''
)
 `

Remove-Item $target_dir -Recurse
mkdir -p $target_dir | Out-Null

pushd $protos_base_dir
protoc `
    -I data-plane-api `
    -I googleapis `
    -I protobuf/src `
    -I protoc-gen-validate `
    -I xds `
    --csharp_out=$target_dir `
    --csharp-grpc_out=$target_dir `
    --csharp_opt=base_namespace='' `
    $files

if (-not $?) { exit 1 }
popd
