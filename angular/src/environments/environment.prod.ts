import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'hrm',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44360/',
    redirectUri: baseUrl,
    clientId: 'hrm_App',
    responseType: 'code',
    scope: 'offline_access hrm',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44360',
      rootNamespace: 'hrm',
    },
  },
} as Environment;
