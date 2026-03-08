# {{ values.projectName }} - Hostinger + GHCR + Traefik starter

Starter repository for deploying a .NET 9 Web API to a Hostinger VPS using:

- GHCR (`ghcr.io`) for container images
- GitHub Actions for build, push and deploy
- Hostinger VPS deployment through SSH
- Traefik already installed on the VPS
- Path-based routing:
  - `https://{{ values.devHost }}{{ values.routePrefix }}`
  - `https://{{ values.stageHost }}{{ values.routePrefix }}`
  - `https://{{ values.prodHost }}{{ values.routePrefix }}`

## What is included

- Minimal .NET 9 Web API
- Dockerfile
- Docker Compose files for dev, stage and prod
- GitHub Actions workflow for build, push and deploy
- Backstage catalog descriptor
- Deploy guide

## Before first deploy

1. Create the DNS records for the three hosts and point them to your Hostinger VPS IP.
2. In GitHub, create these repository secrets:
   - `VPS_HOST`
   - `VPS_USER`
   - `VPS_SSH_KEY`
   - `GHCR_PAT`
   - `GHCR_USERNAME`
3. Confirm your Traefik certificate resolver name is `{{ values.traefikCertResolver }}`.
4. Confirm the external Docker network exists on the VPS: `{{ values.dockerNetwork }}`.

## GHCR image name

The workflow publishes this image:

`ghcr.io/{{ values.owner }}/{{ values.appName }}`

## Branch mapping

- `develop` -> dev
- `stage` -> stage
- `main` -> prod

## Local test

```bash
docker build -t {{ values.appName }}:local .
docker run --rm -p 8080:8080 {{ values.appName }}:local
```

Then open:

- `http://localhost:8080/health`
- `http://localhost:8080/swagger`
