import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'AbpProject',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44388',
    redirectUri: baseUrl,
    clientId: 'AbpProject_App',
    responseType: 'code',
    scope: 'offline_access AbpProject',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44388',
      rootNamespace: 'AbpProject',
    },
  },
} as Environment;
