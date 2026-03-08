# Deploy guide for Hostinger through GitHub Actions

This repository deploys a .NET Web API to a Hostinger VPS using:

- GitHub Actions
- GHCR
- SSH
- Docker Compose
- Traefik

## Workflow trigger

The workflow runs on push to:

- `develop`
- `stage`
- `main`

## Environment mapping

| Branch | Environment | Image tag | VPS folder |
|---|---|---|---|
| `develop` | `dev` | `dev` | `/opt/apps/dev/{{ values.appName }}` |
| `stage` | `stage` | `stage` | `/opt/apps/stage/{{ values.appName }}` |
| `main` | `prod` | `prod` | `/opt/apps/prod/{{ values.appName }}` |

## Required repository secrets

- `VPS_HOST`
- `VPS_USER`
- `VPS_SSH_KEY`
- `GHCR_PAT`
- `GHCR_USERNAME`

## Notes

- The workflow builds and pushes `ghcr.io/{{ values.owner }}/{{ values.appName }}`.
- The compose file is copied to the VPS and renamed to `docker-compose.yml` during deploy.
- The VPS must already have Docker, Docker Compose and Traefik configured.
