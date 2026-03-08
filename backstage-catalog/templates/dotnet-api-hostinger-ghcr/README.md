# Backstage template - .NET API Hostinger GHCR

This Backstage Scaffolder template generates a reusable starter repository for:

- .NET 9 minimal Web API
- Docker multi-stage build
- GHCR publishing
- GitHub Actions CI/CD
- Hostinger VPS deployment via SSH
- Traefik path-based routing
- Backstage catalog registration

## Generated repository contents

- `src/{{projectName}}`
- `Dockerfile`
- `docker/docker-compose.dev.yml`
- `docker/docker-compose.stage.yml`
- `docker/docker-compose.prod.yml`
- `.github/workflows/deploy.yml`
- `README.md`
- `DEPLOY_GUIDE.md`
- `catalog-info.yaml`

## Secrets expected by the generated workflow

Configure these GitHub repository secrets:

- `VPS_HOST`
- `VPS_USER`
- `VPS_SSH_KEY`
- `GHCR_PAT`
- `GHCR_USERNAME`

## Branch mapping

- `develop` -> `dev`
- `stage` -> `stage`
- `main` -> `prod`
