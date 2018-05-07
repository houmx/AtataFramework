﻿using Atata;


namespace AtataFramework
{
    using Pages;
    using System;
    using _ = UserDetailsPage;

    public class UserDetailsPage : Page<_>
    {
        [FindFirst]
        public H1<_> Name { get; private set; }

        [FindByDescriptionTerm]
        public Text<_> Email { get; private set; }

        [FindByDescriptionTerm]
        public Content<Office, _> Office { get; private set; }

        [FindByDescriptionTerm]
        public Content<Gender, _> Gender { get; private set; }

        [FindByDescriptionTerm]
        public Content<DateTime,_> Birthday { get; private set; }

        [FindByDescriptionTerm]
        public Text<_> Notes { get; private set; }
    }
}
