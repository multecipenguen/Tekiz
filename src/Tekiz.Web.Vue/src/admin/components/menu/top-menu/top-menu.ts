﻿import TekizComponentBase from "@/shared/application/Tekiz-component-base";
import { Component } from "vue-property-decorator";
import LanguageStore from "@/stores/language-store";

@Component({
  components: {
    ChangePassword: require("@/admin/components/profile/change-password/change-password.vue")
      .default,
  },
})
export default class TopMenuComponent extends TekizComponentBase {
  public drawer = true;
  public selectedLanguage = {} as ILanguageDto;

  public beforeMount() {
    this.selectedLanguage = LanguageStore.getLanguage();
  }

  public changePasswordDialogChanged(dialog: boolean) {
    this.$root.$emit("changePasswordDialogChanged", dialog);
  }

  public drawerChanged() {
    this.$root.$emit("drawerChanged");
  }

  public changeLanguage(languageCode: string, languageName: string) {
    this.$i18n.locale = languageCode;
    this.selectedLanguage = { languageName, languageCode } as ILanguageDto;
    this.$vuetify.lang.current = languageCode;

    LanguageStore.setLanguage({
      languageCode,
      languageName,
    } as any);
  }

  public logOut() {
    this.authStore.removeToken();
    this.$router.push({ path: "/account/login" });
  }
}
