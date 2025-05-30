import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44389/',
  redirectUri: baseUrl,
  clientId: 'SistemaDeAtencionAlCliente_App',
  responseType: 'code',
  scope: 'offline_access SistemaDeAtencionAlCliente',
  requireHttps: true,
};

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'SistemaDeAtencionAlCliente',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44389',
      rootNamespace: 'SistemaDeAtencionAlCliente',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
  remoteEnv: {
    url: '/getEnvConfig',
    mergeStrategy: 'deepmerge'
  }
} as Environment;
