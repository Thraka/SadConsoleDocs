import type { LocalImageService, ImageTransform } from "astro";
import sharpService, { type SharpImageServiceConfig } from "astro/assets/services/sharp";

const service: LocalImageService = {
    ...sharpService,
    validateOptions(options: ImageTransform, imageConfig) {
      options.quality = 100;
      return sharpService.validateOptions!(options, imageConfig);
    }
};

export default service;