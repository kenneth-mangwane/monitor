<template>
    <header class="header-global">
        <base-nav class="navbar-main" transparent type="" effect="light" expand>
            <router-link slot="brand" class="btn btn-neutral btn-icon mr-lg-5" to="/">

                <span class="btn-inner--icon">
                    <i class="fa fa-home mr-2"></i>
                </span>
                <span class="nav-link-inner--text">Home</span>
            </router-link>
            <router-link slot="brand" class="btn btn-neutral btn-icon mr-lg-5" to="/profile">

                <span class="btn-inner--icon">
                    <i class="fa fa-user mr-2"></i>
                </span>
                <span class="nav-link-inner--text">Account</span>
            </router-link>



        </base-nav>
    </header>
</template>
<script>
import BaseNav from "@/components/BaseNav";
import BaseDropdown from "@/components/BaseDropdown";
import CloseButton from "@/components/CloseButton";

export default {
  components: {
    BaseNav,
    CloseButton,
    BaseDropdown
  }
};
</script>
<style>
</style>
