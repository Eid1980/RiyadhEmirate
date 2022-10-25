// This file can be replaced during build by using the `fileReplacements` array.
// `ng build --prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.

export const environment = {
  production: false,

  ApiUrl: "http://localhost:5000",
  lastSieUpdate: "2022/10/23",

  allowedExtensions: 'image/*',
  fileSize: 4000000,

  auctionsallowedExtensions: 'image/*',
  auctionsfileSize: 2000000,
  governoratesallowedExtensions: 'image/*',
  governoratesfileSize: 2000000,
  newsallowedExtensions: 'image/*',
  newsfileSize: 1500000,
  postersallowedExtensions: 'image/*',
  postersfileSize: 3000000,
  princesallowedExtensions: 'image/*',
  princesfileSize: 2000000,
  servicesallowedExtensions: 'image/*',
  servicesfileSize: 2000000,
  serviceExplainAllowedExtensions: 'image/*',
  serviceExplainFileSize: 6000000,
  openDataAllowedExtensions: '.xlsx,.xlsm,.xlsb,.xls,.xlt',
  openDataFileSize: 6000000,
};

/*
 * For easier debugging in development mode, you can import the following file
 * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
 *
 * This import should be commented out in production mode because it will have a negative impact
 * on performance if an error is thrown.
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.
