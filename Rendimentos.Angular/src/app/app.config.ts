import { provideHttpClient } from "@angular/common/http";
import {
  ApplicationConfig,
  provideExperimentalZonelessChangeDetection,
} from "@angular/core";
import { NgxMaskConfig, provideEnvironmentNgxMask } from "ngx-mask";

const maskConfig: Partial<NgxMaskConfig> = {
  allowNegativeNumbers: false,
  thousandSeparator: ".",
  decimalMarker: ",",
};

export const appConfig: ApplicationConfig = {
  providers: [
    provideExperimentalZonelessChangeDetection(),
    provideEnvironmentNgxMask(maskConfig),
    provideHttpClient(),
  ],
};
