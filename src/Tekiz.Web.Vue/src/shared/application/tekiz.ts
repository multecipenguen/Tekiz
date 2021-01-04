import TekizService  from '@/shared/application/tekiz-service-proxy';
import AuthStore from "@/stores/auth-store";
import { appConst } from "../../settings";

const Tekiz = {
  baseApiUrl: appConst.webApiUrl,
  baseClientUrl: appConst.webClientUrl,
  isLoading: false,
  appVersion: "1.0.0",
  auth: {
    grantedPermissions: [] as IPermissionDto[],
    isGranted(permissionName: string) {
      return (
        this.grantedPermissions.filter((p) => p.name == permissionName).length >
        0
      );
    },
    removeProps() {
      this.grantedPermissions = [];
    },
    fillProps() {
      const tekizService = new TekizService();
      tekizService.get<IPermissionDto[]>(
        "/api/permissions?userNameOrEmail=" + AuthStore.getTokenData().sub
      ).then((response) => {
        if (!response.isError) {
          this.grantedPermissions = response.content as IPermissionDto[];
        }
      });
    },
  },
};

export default Tekiz;
