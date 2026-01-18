FROM lscr.io/linuxserver/radarr:latest

# copy your locally-built Radarr binaries
COPY ./_output/net8.0/linux-musl-x64 /app/radarr/bin
COPY ./_output/UI /app/radarr/bin/UI

# ensure executable
RUN chmod +x /app/radarr/bin/Radarr
RUN chmod +x /app/radarr/bin/UI

