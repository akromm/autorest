# coding=utf-8
# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.service_client import ServiceClient
from msrest import Configuration, Serializer, Deserializer
from .operations.int_model import IntModel
from . import models


class AutoRestIntegerTestServiceConfiguration(Configuration):
    """Configuration for AutoRestIntegerTestService
    Note that all parameters used to create this instance are saved as instance
    attributes.

    :param str base_url: Service URL
    :param str filepath: Existing config
    """

    def __init__(
            self, base_url=None, filepath=None):

        if not base_url:
            base_url = 'https://localhost'

        super(AutoRestIntegerTestServiceConfiguration, self).__init__(base_url, filepath)

        self.add_user_agent('autorestintegertestservice/1.0.0')


class AutoRestIntegerTestService(object):
    """Test Infrastructure for AutoRest

    :param config: Configuration for client.
    :type config: AutoRestIntegerTestServiceConfiguration

    :ivar int_model: IntModel operations
    :vartype int_model: .operations.IntModel
    """

    def __init__(self, config):

        self._client = ServiceClient(None, config)

        client_models = {k: v for k, v in models.__dict__.items() if isinstance(v, type)}
        self._serialize = Serializer()
        self._deserialize = Deserializer(client_models)

        self.config = config
        self.int_model = IntModel(
            self._client, self.config, self._serialize, self._deserialize)
