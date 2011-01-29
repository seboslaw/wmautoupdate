require 'webrick'
include WEBrick

mime_types = WEBrick::HTTPUtils::DefaultMimeTypes
mime_types.store 'js', 'application/javascript'

s = HTTPServer.new(
  :DocumentRoot    => ".",
  :BindAddress     => "127.0.0.1",
  :Port            => "80",
  :MimeTypes       => mime_types
)
t = Thread.new {
  s.start
}

trap("INT") { s.shutdown }
t.join()
